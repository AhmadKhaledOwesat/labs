using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class InsuranceCompanyBll(IBaseDal<InsuranceCompany, Guid, InsuranceCompanyFilter> baseDal) : BaseBll<InsuranceCompany, Guid, InsuranceCompanyFilter>(baseDal), IInsuranceCompanyBll
    {
        public override Task<PageResult<InsuranceCompany>> GetAllAsync(InsuranceCompanyFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
