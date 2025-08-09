using JoLab.Application.Dto;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class ReportParameterBll(IBaseDal<ReportParameter, Guid, ReportParameterFilter> baseDal) : BaseBll<ReportParameter, Guid, ReportParameterFilter>(baseDal), IReportParameterBll
    {
    }
}
