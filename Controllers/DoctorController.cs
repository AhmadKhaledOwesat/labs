using JoLab.Application.Dto;
using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace JoLab.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class DoctorController(IDoctorBll DoctorBll, IJoLabMapper mapper) : BaseController<Doctor, DoctorDto, Guid, DoctorFilter>(DoctorBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<DoctorDto>>> SearchAsync([FromBody] DoctorFilter searchParameters)
        {
            return new ApiResponse<PageResult<DoctorDto>>(mapper.Map<PageResult<DoctorDto>>(await DoctorBll.GetAllAsync(searchParameters)));
        }
    }
}
