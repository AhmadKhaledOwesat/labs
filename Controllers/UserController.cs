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
    public class UserController(IUserBll userBll,IJoLabMapper mapper) : BaseController<Users,UsersDto,Guid,UserFilter>(userBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<UsersDto>>> SearchAsync([FromBody] UserFilter searchParameters)=> new ApiResponse<PageResult<UsersDto>>(mapper.Map<PageResult<UsersDto>>(await userBll.GetAllAsync(searchParameters)));
        [HttpGet]
        [Route("login/{userName}/{password}/{companyCode}")]
        public async Task<ApiResponse<UsersDto>> LoginAsync(string userName, string password, string companyCode) => await userBll.LoginAsync(userName,  password, companyCode);
    }
}
