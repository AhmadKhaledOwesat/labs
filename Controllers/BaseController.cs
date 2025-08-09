using JoLab.Application.Dto;
using JoLab.Application.Interfaces;
using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace JoLab.Controllers
{
    public class BaseController<T, TDto, TId, TFilter>(IBaseBll<T, TId, TFilter> _baseBll, IJoLabMapper _mapper) : Controller
        where T : BaseEntity<TId>
        where TDto : BaseDto<TId>
        where TId : struct
    {
        protected IJoLabMapper mapper = _mapper;
        protected IBaseBll<T, TId, TFilter> baseBll = _baseBll;

        [HttpPost]
        [Route("")]
        [DisableRequestSizeLimit]
        public virtual async Task<ApiResponse<TId>> AddAsync([FromBody] TDto dto)
        {
            T entity = mapper.Map<T>(dto);
            await baseBll.AddAsync(entity);
            return new ApiResponse<TId>(entity.Id);
        }

        [HttpPost]
        [Route("update")]
        [DisableRequestSizeLimit]
        public virtual async Task<ApiResponse<TId>> UpdateAsync([FromBody] TDto dto)
        {
            T entity = mapper.Map<T>(dto);
            await baseBll.UpdateAsync(entity);
            return new ApiResponse<TId>(entity.Id);
        }
        [HttpGet]
        [Route("delete/{id}")]
        public virtual async Task<ApiResponse<bool>> DeleteAsync([FromRoute] TId id) => new ApiResponse<bool>(await baseBll.DeleteAsync(id));
        [HttpGet]
        [Route("{id}")]
        public virtual async Task<ApiResponse<TDto>> GetByIdAsync([FromRoute] TId id) => new ApiResponse<TDto>(mapper.Map<TDto>(await baseBll.GetByIdAsync(id)));

        [HttpPost]
        [Route("search")]
        public virtual async Task<ApiResponse<PageResult<TDto>>> SearchAsync([FromBody] TFilter searchParameters) => new ApiResponse<PageResult<TDto>>(mapper.Map<PageResult<TDto>>(await baseBll.GetAllAsync(searchParameters)));
    }
}
