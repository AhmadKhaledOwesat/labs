using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class IndicatorBll(IBaseDal<Indicator, Guid, IndicatorFilter> baseDal) : BaseBll<Indicator, Guid, IndicatorFilter>(baseDal), IIndicatorBll
    {
        public override Task<PageResult<Indicator>> GetAllAsync(IndicatorFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
