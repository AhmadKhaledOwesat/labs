using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class CityBll(IBaseDal<City, Guid, CityFilter> baseDal) : BaseBll<City, Guid, CityFilter>(baseDal), ICityBll
    {
        public override Task<PageResult<City>> GetAllAsync(CityFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
