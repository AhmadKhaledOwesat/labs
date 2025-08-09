using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IPrivilegeBll : IBaseBll<Privilege, Guid, PrivilegeFilter>
    {
    }
}
