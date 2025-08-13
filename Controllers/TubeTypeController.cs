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
    public class TubeTypeController(ITubeTypeBll TubeTypeBll, IJoLabMapper mapper) : BaseController<TubeType, TubeTypeDto, Guid, TubeTypeFilter>(TubeTypeBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<TubeTypeDto>>> SearchAsync([FromBody] TubeTypeFilter searchParameters)
        {
            return new ApiResponse<PageResult<TubeTypeDto>>(mapper.Map<PageResult<TubeTypeDto>>(await TubeTypeBll.GetAllAsync(searchParameters)));
        }
    }
}
