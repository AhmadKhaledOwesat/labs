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
    public class ClientFileController(ClientFileBll ClientFileBll,IJoLabMapper mapper) : BaseController<ClientFile,ClientFileDto,Guid,ClientFileFilter>(ClientFileBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ClientFileDto>>> SearchAsync([FromBody] ClientFileFilter searchParameters)
        {
            return  new ApiResponse<PageResult<ClientFileDto>>(mapper.Map<PageResult<ClientFileDto>>(await ClientFileBll.GetAllAsync(searchParameters)));      
        }
    }
}
