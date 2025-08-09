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
    public class UserRoleController(IUserRoleBll UserRoleBll,IJoLabMapper mapper) : BaseController<UserRole,UserRoleDto,Guid,UserRoleFilter>(UserRoleBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<UserRoleDto>>> SearchAsync([FromBody] UserRoleFilter searchParameters)
        {
            return  new ApiResponse<PageResult<UserRoleDto>>(mapper.Map<PageResult<UserRoleDto>>(await UserRoleBll.GetAllAsync(searchParameters)));      
        }
    }
}
