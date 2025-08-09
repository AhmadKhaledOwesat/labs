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
    public class SettingController(ISettingBll settingBll, IJoLabMapper mapper) : BaseController<Setting, SettingDto, Guid, SettingFilter>(settingBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<SettingDto>>> SearchAsync([FromBody] SettingFilter searchParameters)=> new ApiResponse<PageResult<SettingDto>>(mapper.Map<PageResult<SettingDto>>(await settingBll.GetAllAsync(searchParameters)));
    }
}
