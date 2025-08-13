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
    public class ClientInsuranceController(ClientInsuranceBll ClientInsuranceBll,IJoLabMapper mapper) : BaseController<ClientInsurance,ClientInsuranceDto,Guid,ClientInsuranceFilter>(ClientInsuranceBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ClientInsuranceDto>>> SearchAsync([FromBody] ClientInsuranceFilter searchParameters)
        {
            return  new ApiResponse<PageResult<ClientInsuranceDto>>(mapper.Map<PageResult<ClientInsuranceDto>>(await ClientInsuranceBll.GetAllAsync(searchParameters)));      
        }
    }
}
