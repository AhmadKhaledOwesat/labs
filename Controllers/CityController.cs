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
    public class CityController(ICityBll CityBll, IJoLabMapper mapper) : BaseController<City, CityDto, Guid, CityFilter>(CityBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<CityDto>>> SearchAsync([FromBody] CityFilter searchParameters)
        {
            return new ApiResponse<PageResult<CityDto>>(mapper.Map<PageResult<CityDto>>(await CityBll.GetAllAsync(searchParameters)));
        }
    }
}
