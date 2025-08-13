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
    public class OrderMasterController(IOrderMasterBll OrderMasterBll, IJoLabMapper mapper) : BaseController<OrderMaster, OrderMasterDto, Guid, OrderMasterFilter>(OrderMasterBll, mapper)
    {
        public override async Task<ApiResponse<PageResult<OrderMasterDto>>> SearchAsync([FromBody] OrderMasterFilter searchParameters)
        {
            return new ApiResponse<PageResult<OrderMasterDto>>(mapper.Map<PageResult<OrderMasterDto>>(await OrderMasterBll.GetAllAsync(searchParameters)));
        }
    }
}
