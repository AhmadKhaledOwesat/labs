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
    public class TestNormalRangeController(ITestNormalRangeBll TestNormalRangeBll, IJoLabMapper mapper) : BaseController<TestNormalRange, TestNormalRangeDto, Guid, TestNormalRangeFilter>(TestNormalRangeBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<TestNormalRangeDto>>> SearchAsync([FromBody] TestNormalRangeFilter searchParameters)
        {
            return new ApiResponse<PageResult<TestNormalRangeDto>>(mapper.Map<PageResult<TestNormalRangeDto>>(await TestNormalRangeBll.GetAllAsync(searchParameters)));
        }
    }
}
