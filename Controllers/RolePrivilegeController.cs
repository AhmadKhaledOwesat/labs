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
    public class RolePrivilegeController(IRolePrivilegeBll RolePrivilegeBll,IJoLabMapper mapper) : BaseController<RolePrivilege,RolePrivilegeDto,Guid,RolePrivilegeFilter>(RolePrivilegeBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<RolePrivilegeDto>>> SearchAsync([FromBody] RolePrivilegeFilter searchParameters)
        {
            return  new ApiResponse<PageResult<RolePrivilegeDto>>(mapper.Map<PageResult<RolePrivilegeDto>>(await RolePrivilegeBll.GetAllAsync(searchParameters)));      
        }
    }
}
