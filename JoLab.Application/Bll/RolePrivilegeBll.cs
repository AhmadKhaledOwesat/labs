using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class RolePrivilegeBll(IBaseDal<RolePrivilege, Guid, RolePrivilegeFilter> baseDal) : BaseBll<RolePrivilege, Guid, RolePrivilegeFilter>(baseDal), IRolePrivilegeBll
    {
        public override Task<PageResult<RolePrivilege>> GetAllAsync(RolePrivilegeFilter searchParameters)
        {
            searchParameters.Expression = new Func<RolePrivilege, bool>(x => x.RoleId == searchParameters.RoleId);
            return base.GetAllAsync(searchParameters);
        }
    }
}
