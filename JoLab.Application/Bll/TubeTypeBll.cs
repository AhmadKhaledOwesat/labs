using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class TubeTypeBll(IBaseDal<TubeType, Guid, TubeTypeFilter> baseDal) : BaseBll<TubeType, Guid, TubeTypeFilter>(baseDal), ITubeTypeBll
    {
        public override Task<PageResult<TubeType>> GetAllAsync(TubeTypeFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
