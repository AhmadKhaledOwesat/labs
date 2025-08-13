using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class TestInsurancePlanBll(IBaseDal<TestInsurancePlan, Guid, TestInsurancePlanFilter> baseDal) : BaseBll<TestInsurancePlan, Guid, TestInsurancePlanFilter>(baseDal), ITestInsurancePlanBll
    {
        public override Task<PageResult<TestInsurancePlan>> GetAllAsync(TestInsurancePlanFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
