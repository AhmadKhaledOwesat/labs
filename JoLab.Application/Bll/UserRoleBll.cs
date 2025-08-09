using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class UserRoleBll(IBaseDal<UserRole, Guid, UserRoleFilter> baseDal) : BaseBll<UserRole, Guid, UserRoleFilter>(baseDal), IUserRoleBll
    {
        public override Task<PageResult<UserRole>> GetAllAsync(UserRoleFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
