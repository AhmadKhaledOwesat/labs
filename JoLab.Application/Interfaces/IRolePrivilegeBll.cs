using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IRolePrivilegeBll : IBaseBll<RolePrivilege, Guid, RolePrivilegeFilter>
    {
    }
}
