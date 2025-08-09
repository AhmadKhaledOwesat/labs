using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using JoLab.Infrastructure.Extensions;

namespace JoLab.Application.Bll
{
    public class ReportBll(IBaseDal<Report, Guid, ReportFilter> baseDal) : BaseBll<Report, Guid, ReportFilter>(baseDal), IReportBll
    {
        public override Task<PageResult<Report>> GetAllAsync(ReportFilter searchParameters)
        {
            if (searchParameters is not null)
            {
                    searchParameters.Expression = new Func<Report, bool>(a => 
                    (a.ReportName == searchParameters?.Name || searchParameters.Name.IsNullOrEmpty())
                    && a.CompanyId == searchParameters.CompanyId
                    );
            }

            return base.GetAllAsync(searchParameters);
        }

        public async Task<ApiResponse<dynamic>> ExecuteReport(string query)
        {
            dynamic data = await baseDal.ExecuteSQL(query);
            return new ApiResponse<dynamic>(data);
        }
    }
}
