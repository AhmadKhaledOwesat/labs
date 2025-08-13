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
    public class TestInsurancePlanController(TestInsurancePlanBll TestInsurancePlanBll,IJoLabMapper mapper) : BaseController<TestInsurancePlan,TestInsurancePlanDto,Guid,TestInsurancePlanFilter>(TestInsurancePlanBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<TestInsurancePlanDto>>> SearchAsync([FromBody] TestInsurancePlanFilter searchParameters)
        {
            return  new ApiResponse<PageResult<TestInsurancePlanDto>>(mapper.Map<PageResult<TestInsurancePlanDto>>(await TestInsurancePlanBll.GetAllAsync(searchParameters)));      
        }
    }
}
