using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ClientBll(IBaseDal<Client, Guid, ClientFilter> baseDal) : BaseBll<Client, Guid, ClientFilter>(baseDal), IClientBll
    {
        public override Task<PageResult<Client>> GetAllAsync(ClientFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
