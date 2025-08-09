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
    public class ReportController(IReportBll ReportBll, IJoLabMapper mapper) : BaseController<Report, ReportDto, Guid, ReportFilter>(ReportBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<ReportDto>>> SearchAsync([FromBody] ReportFilter searchParameters)=> new ApiResponse<PageResult<ReportDto>>(mapper.Map<PageResult<ReportDto>>(await ReportBll.GetAllAsync(searchParameters)));
        [HttpGet]
        [Route("excute/{query}")]
        public  async Task<ApiResponse<dynamic>> ExecuteReportAsync([FromRoute] string query) => await ReportBll.ExecuteReport(query);

    }
}
