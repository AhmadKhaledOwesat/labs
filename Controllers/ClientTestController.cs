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
    public class ClientTestController(ClientTestBll ClientTestBll,IJoLabMapper mapper) : BaseController<ClientTest,ClientTestDto,Guid,ClientTestFilter>(ClientTestBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ClientTestDto>>> SearchAsync([FromBody] ClientTestFilter searchParameters)
        {
            return  new ApiResponse<PageResult<ClientTestDto>>(mapper.Map<PageResult<ClientTestDto>>(await ClientTestBll.GetAllAsync(searchParameters)));      
        }
    }
}
