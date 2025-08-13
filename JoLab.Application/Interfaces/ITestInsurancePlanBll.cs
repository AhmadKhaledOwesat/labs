using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Interfaces
{
    public interface ITestInsurancePlanBll : IBaseBll<TestInsurancePlan, Guid, TestInsurancePlanFilter>
    {
    }
}
