using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ClientFileBll(IBaseDal<ClientFile, Guid, ClientFileFilter> baseDal) : BaseBll<ClientFile, Guid, ClientFileFilter>(baseDal), IClientFileBll
    {
        public override Task<PageResult<ClientFile>> GetAllAsync(ClientFileFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
