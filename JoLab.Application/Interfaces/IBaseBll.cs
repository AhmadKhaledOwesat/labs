﻿using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using System.Linq.Expressions;

namespace JoLab.Domain.Interfaces
{
    public interface IBaseBll<T, TId, TFilter> where T : BaseEntity<TId>
        where TId : struct
    {
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task<T> GetByIdAsync(TId id);
        Task<List<T>> GetAllAsync();
        Task<PageResult<T>> GetAllAsync(TFilter searchParameters);
        Task<T> FindByExpressionAsync(Expression<Func<T, bool>> expression);
        Task<List<T>> FindAllByExpressionAsync(Expression<Func<T, bool>> expression);
        Task DeleteRangeAsync(List<T> entities);
        Task<bool> DeleteAsync(TId id);
        Task AddRangeAsync(List<T> entities);
        Task UpdateRangeAsync(List<T> entities);
        Task<int> GetCountByExpressionAsync(Expression<Func<T, bool>> expression);
    }
}
