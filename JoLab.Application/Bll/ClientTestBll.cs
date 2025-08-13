using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ClientTestBll(IBaseDal<ClientTest, Guid, ClientTestFilter> baseDal) : BaseBll<ClientTest, Guid, ClientTestFilter>(baseDal), IClientTestBll
    {
        public override Task<PageResult<ClientTest>> GetAllAsync(ClientTestFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
