using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;

namespace JoLab.Application.Bll
{
    public class OrderDetailsBll(IBaseDal<OrderDetails, Guid, OrderDetailsFilter> baseDal) : BaseBll<OrderDetails, Guid, OrderDetailsFilter>(baseDal), IOrderDetailsBll
    {
        public override Task<PageResult<OrderDetails>> GetAllAsync(OrderDetailsFilter searchParameters)
        {
            return base.GetAllAsync(searchParameters);
        }

    }
}
