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
    public class SpecialtyController(ISpecialtyBll SpecialtyBll, IJoLabMapper mapper) : BaseController<Specialty, SpecialtyDto, Guid, SpecialtyFilter>(SpecialtyBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<SpecialtyDto>>> SearchAsync([FromBody] SpecialtyFilter searchParameters)
        {
            return new ApiResponse<PageResult<SpecialtyDto>>(mapper.Map<PageResult<SpecialtyDto>>(await SpecialtyBll.GetAllAsync(searchParameters)));
        }
    }
}
