using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class DoctorBll(IBaseDal<Doctor, Guid, DoctorFilter> baseDal) : BaseBll<Doctor, Guid, DoctorFilter>(baseDal), IDoctorBll
    {
        public override Task<PageResult<Doctor>> GetAllAsync(DoctorFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
