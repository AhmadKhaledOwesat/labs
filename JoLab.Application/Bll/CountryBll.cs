using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class CountryBll(IBaseDal<Country, Guid, CountryFilter> baseDal) : BaseBll<Country, Guid, CountryFilter>(baseDal), ICountryBll
    {
        public override Task<PageResult<Country>> GetAllAsync(CountryFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
