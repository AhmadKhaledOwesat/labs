using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class OrderMasterBll(IBaseDal<OrderMaster, Guid, OrderMasterFilter> baseDal) : BaseBll<OrderMaster, Guid, OrderMasterFilter>(baseDal), IOrderMasterBll
    {
        public override Task<PageResult<OrderMaster>> GetAllAsync(OrderMasterFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
