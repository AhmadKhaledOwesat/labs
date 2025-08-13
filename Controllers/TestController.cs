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
    public class TestController(ITestBll TestBll, IJoLabMapper mapper) : BaseController<Test, TestDto, Guid, TestFilter>(TestBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<TestDto>>> SearchAsync([FromBody] TestFilter searchParameters)
        {
            return new ApiResponse<PageResult<TestDto>>(mapper.Map<PageResult<TestDto>>(await TestBll.GetAllAsync(searchParameters)));
        }
    }
}
