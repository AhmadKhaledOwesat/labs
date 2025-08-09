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
    public class PrivilegeController(IPrivilegeBll PrivilegeBll,IJoLabMapper mapper) : BaseController<Privilege,PrivilegeDto,Guid,PrivilegeFilter>(PrivilegeBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<PrivilegeDto>>> SearchAsync([FromBody] PrivilegeFilter searchParameters)
        {
            return  new ApiResponse<PageResult<PrivilegeDto>>(mapper.Map<PageResult<PrivilegeDto>>(await PrivilegeBll.GetAllAsync(searchParameters)));      
        }
    }
}
