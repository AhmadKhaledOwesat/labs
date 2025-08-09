using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IUserRoleBll : IBaseBll<UserRole, Guid, UserRoleFilter>
    {
    }
}
