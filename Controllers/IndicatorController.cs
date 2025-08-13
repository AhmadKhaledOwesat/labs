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
    public class IndicatorController(IIndicatorBll IndicatorBll, IJoLabMapper mapper) : BaseController<Indicator, IndicatorDto, Guid, IndicatorFilter>(IndicatorBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<IndicatorDto>>> SearchAsync([FromBody] IndicatorFilter searchParameters)
        {
            return new ApiResponse<PageResult<IndicatorDto>>(mapper.Map<PageResult<IndicatorDto>>(await IndicatorBll.GetAllAsync(searchParameters)));
        }
    }
}
