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
    public class CountryController(ICountryBll CountryBll, IJoLabMapper mapper) : BaseController<Country, CountryDto, Guid, CountryFilter>(CountryBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<CountryDto>>> SearchAsync([FromBody] CountryFilter searchParameters)
        {
            return new ApiResponse<PageResult<CountryDto>>(mapper.Map<PageResult<CountryDto>>(await CountryBll.GetAllAsync(searchParameters)));
        }
    }
}
