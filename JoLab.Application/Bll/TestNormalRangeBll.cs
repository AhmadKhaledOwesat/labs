using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class TestNormalRangeBll(IBaseDal<TestNormalRange, Guid, TestNormalRangeFilter> baseDal) : BaseBll<TestNormalRange, Guid, TestNormalRangeFilter>(baseDal), ITestNormalRangeBll
    {
        public override Task<PageResult<TestNormalRange>> GetAllAsync(TestNormalRangeFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
