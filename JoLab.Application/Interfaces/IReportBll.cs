using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Interfaces
{
    public interface IReportBll : IBaseBll<Report, Guid, ReportFilter>
    {
        Task<ApiResponse<dynamic>> ExecuteReport(string query);
    }
}
