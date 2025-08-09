using JoLab.Application.Dto;
using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using JoLab.Infrastructure.Extensions;
using System.Linq.Expressions;

namespace JoLab.Application.Bll
{
    public class UserBll(IBaseDal<Users, Guid, UserFilter> baseDal, IJoLabMapper dcpMapper, IUserRoleBll userRoleBll) : BaseBll<Users, Guid, UserFilter>(baseDal), IUserBll
    {
        public override async Task AddAsync(Users entity)
        {
            entity.Password = entity.Password.HashedPassword();
            await base.AddAsync(entity);
        }
        public async Task<ApiResponse<UsersDto>> LoginAsync(string userName, string password, string companyCode)
        {
            Users user = await baseDal.FindByExpressionAsync(x=>x.Password == password.HashedPassword() && x.UserName == userName);
            if (user == null) return new ApiResponse<UsersDto>(null, "الرجاء التاكد من كلمة المرور ورمز المستخدم", false);
            UsersDto usersDto = dcpMapper.Map<UsersDto>(user);
            usersDto.Permssions = user.UserRoles.Where(a=>a.Role != null && a.Role.Active == 1).SelectMany(a => a.Role?.RolePrivileges).Select(x => x.PrivilegeId).ToArray() ?? [];
            return new ApiResponse<UsersDto>(usersDto);
        }
        public override Task<PageResult<Users>> GetAllAsync(UserFilter searchParameters)
        {
            if (searchParameters is not null)
            {
                    searchParameters.Expression = new Func<Users, bool>(a => 
                      (a.UserName == searchParameters?.UserName || searchParameters.UserName.IsNullOrEmpty())
                    && a.CompanyId == searchParameters.CompanyId);
            }

            return base.GetAllAsync(searchParameters);
        }

        public override async Task UpdateAsync(Users entity)
        {
            if (!string.IsNullOrEmpty(entity.NewPassword))
                entity.Password = entity.NewPassword.HashedPassword();
            if (entity.OperationType.HasFlag(Domain.Enum.OperationType.UserRole))
                await HandleUserRoles(entity);
            await base.UpdateAsync(entity);
        }

        private async Task HandleUserRoles(Users entity)
        {
            Expression<Func<UserRole, bool>> expression = x => x.UserId == entity.Id;
            List<UserRole> userRoles = await userRoleBll.FindAllByExpressionAsync(expression);
            if (userRoles.Count > 0)
                await userRoleBll.DeleteRangeAsync(userRoles);
            await userRoleBll.AddRangeAsync([.. entity.UserRoles]);
        }
    }
}
