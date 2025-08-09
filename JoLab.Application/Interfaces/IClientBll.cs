using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IClientBll : IBaseBll<Client, Guid, ClientFilter>
    {
    }
}
