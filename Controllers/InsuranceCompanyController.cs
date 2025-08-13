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
    public class InsuranceCompanyController(IInsuranceCompanyBll InsuranceCompanyBll, IJoLabMapper mapper) : BaseController<InsuranceCompany, InsuranceCompanyDto, Guid, InsuranceCompanyFilter>(InsuranceCompanyBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<InsuranceCompanyDto>>> SearchAsync([FromBody] InsuranceCompanyFilter searchParameters)
        {
            return new ApiResponse<PageResult<InsuranceCompanyDto>>(mapper.Map<PageResult<InsuranceCompanyDto>>(await InsuranceCompanyBll.GetAllAsync(searchParameters)));
        }
    }
}
