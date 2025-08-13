using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IClientIndicatorBll : IBaseBll<ClientIndicator, Guid, ClientIndicatorFilter>
    {
    }
}
