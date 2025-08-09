using JoLab.Application.Dto;
using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace JoLab.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors("AllowAllOrigins")]
    public class ClientController(IClientBll clientBll,IJoLabMapper mapper) : BaseController<Client,ClientDto,Guid,ClientFilter>(clientBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ClientDto>>> SearchAsync([FromBody] ClientFilter searchParameters)
        {
            return  new ApiResponse<PageResult<ClientDto>>(mapper.Map<PageResult<ClientDto>>(await clientBll.GetAllAsync(searchParameters)));      
        }
    }
}
