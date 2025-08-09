using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;

namespace JoLab.Domain.Interfaces
{
    public interface ISettingBll : IBaseBll<Setting, Guid, SettingFilter>
    {
    }
}
