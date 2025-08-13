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
    public class OrderDetailsController(IOrderDetailsBll OrderDetailsBll, IJoLabMapper mapper) : BaseController<OrderDetails, OrderDetailsDto, Guid, OrderDetailsFilter>(OrderDetailsBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<OrderDetailsDto>>> SearchAsync([FromBody] OrderDetailsFilter searchParameters)
        {
            return new ApiResponse<PageResult<OrderDetailsDto>>(mapper.Map<PageResult<OrderDetailsDto>>(await OrderDetailsBll.GetAllAsync(searchParameters)));
        }
    }
}
