using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ClientInsuranceBll(IBaseDal<ClientInsurance, Guid, ClientInsuranceFilter> baseDal) : BaseBll<ClientInsurance, Guid, ClientInsuranceFilter>(baseDal), IClientInsuranceBll
    {
        public override Task<PageResult<ClientInsurance>> GetAllAsync(ClientInsuranceFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
