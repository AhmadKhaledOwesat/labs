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
    public class ReportParameterController(IReportParameterBll ReportParameterBll, IJoLabMapper mapper) : BaseController<ReportParameter, ReportParameterDto, Guid, ReportParameterFilter>(ReportParameterBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ReportParameterDto>>> SearchAsync([FromBody] ReportParameterFilter searchParameters) => new ApiResponse<PageResult<ReportParameterDto>>(mapper.Map<PageResult<ReportParameterDto>>(await ReportParameterBll.GetAllAsync(searchParameters)));
    }
}
