using JoLab.Application.Bll;
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
    public class ClientIndicatorController(ClientIndicatorBll ClientIndicatorBll,IJoLabMapper mapper) : BaseController<ClientIndicator,ClientIndicatorDto,Guid,ClientIndicatorFilter>(ClientIndicatorBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ClientIndicatorDto>>> SearchAsync([FromBody] ClientIndicatorFilter searchParameters)
        {
            return  new ApiResponse<PageResult<ClientIndicatorDto>>(mapper.Map<PageResult<ClientIndicatorDto>>(await ClientIndicatorBll.GetAllAsync(searchParameters)));      
        }
    }
}
