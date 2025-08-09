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
    public class RoleController(IRoleBll RoleBll,IJoLabMapper mapper) : BaseController<Role,RoleDto,Guid,RoleFilter>(RoleBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<RoleDto>>> SearchAsync([FromBody] RoleFilter searchParameters)
        {
            return  new ApiResponse<PageResult<RoleDto>>(mapper.Map<PageResult<RoleDto>>(await RoleBll.GetAllAsync(searchParameters)));      
        }
    }
}
