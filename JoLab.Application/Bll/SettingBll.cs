using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using Microsoft.Extensions.Configuration;

namespace JoLab.Application.Bll
{
    public class SettingBll(IBaseDal<Setting, Guid, SettingFilter> baseDal) : BaseBll<Setting, Guid, SettingFilter>(baseDal), ISettingBll
    {
        public override async Task<PageResult<Setting>> GetAllAsync(SettingFilter searchParameters)
        {

            if (searchParameters is not null)
            {
                searchParameters.Expression = new Func<Setting, bool>(a => a.IsSystem == 0);
            }

            return await base.GetAllAsync(searchParameters);
        }
    }
}
