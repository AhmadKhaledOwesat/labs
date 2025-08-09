using JoLab.Application.Dto;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface IReportParameterBll : IBaseBll<ReportParameter, Guid, ReportParameterFilter>
    {
    }
}
