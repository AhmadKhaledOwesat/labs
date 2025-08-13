using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class SpecialtyBll(IBaseDal<Specialty, Guid, SpecialtyFilter> baseDal) : BaseBll<Specialty, Guid, SpecialtyFilter>(baseDal), ISpecialtyBll
    {
        public override Task<PageResult<Specialty>> GetAllAsync(SpecialtyFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
