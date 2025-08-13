using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ClientIndicatorBll(IBaseDal<ClientIndicator, Guid, ClientIndicatorFilter> baseDal) : BaseBll<ClientIndicator, Guid, ClientIndicatorFilter>(baseDal), IClientIndicatorBll
    {
        public override Task<PageResult<ClientIndicator>> GetAllAsync(ClientIndicatorFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
