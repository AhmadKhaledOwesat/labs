using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class TestBll(IBaseDal<Test, Guid, TestFilter> baseDal) : BaseBll<Test, Guid, TestFilter>(baseDal), ITestBll
    {
        public override Task<PageResult<Test>> GetAllAsync(TestFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
