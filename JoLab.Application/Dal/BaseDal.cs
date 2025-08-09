﻿using JoLab.Domain.Entities;
using JoLab.Domain.Entities.Filters;
using JoLab.Domain.Interfaces;
using JoLab.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JoLab.Application.Dal
{
    public class BaseDal<T, TId, TFilter>(IEfRepository<T, TId> efRepository) : IBaseDal<T, TId, TFilter> where T : BaseEntity<TId>
        where TId : struct
        where TFilter : SearchParameters<T>
    {
        public virtual async Task AddAsync(T entity)
        {
            entity.CreatedDate = DateTime.Now;
            if (typeof(TId) == typeof(int))
                entity.CreatedBy = (TId)(object)0;
            else
                entity.CreatedBy = (TId)(object)Guid.NewGuid();
            await efRepository.InsertAsync(entity);
        }

        public virtual async Task<List<T>> GetAllAsync() => await efRepository.Table.ToListAsync();
        public virtual async Task<T> FindByExpressionAsync(Expression<Func<T, bool>> expression) => await efRepository.Table.FirstOrDefaultAsync(expression);
        public virtual async Task<List<T>> FindAllByExpressionAsync(Expression<Func<T, bool>> expression) => await efRepository.Table.Where(expression).ToListAsync();
        public virtual async Task<int> GetCountByExpressionAsync(Expression<Func<T, bool>> expression) => await efRepository.Table.Where(expression).CountAsync();

        public virtual async Task<PageResult<T>> GetAllAsync(TFilter searchParameters)
        {
            var result = await GetAllAsync();

            if (searchParameters.Expression != null)
                result = [.. result.Where(searchParameters.Expression)];

            return new PageResult<T>
            {
                Collections = [.. result.Skip(((searchParameters.PagingParameters?.PageNumber ?? 1) - 1) * (searchParameters.PagingParameters?.PageSize ?? 10)).Take(searchParameters.PagingParameters?.PageSize ?? 10)],
                Count = result.Count,
            };
        }

        public virtual async Task<T> GetByIdAsync(TId id) => await efRepository.GetByIdAsync(id);

        public virtual async Task UpdateAsync(T entity)
        {
            entity.ModifiedDate = DateTime.Now;
            if (typeof(TId) == typeof(int))
                entity.ModifiedBy = (TId)(object)0;
            else
                entity.ModifiedBy = (TId)(object)Guid.NewGuid();
            await efRepository.UpdateAsync(entity);
        }

        public virtual async Task DeleteRangeAsync(List<T> entities)
        {
            await efRepository.DeleteRangeAsync(entities);
        }
        public virtual async Task<bool> DeleteAsync(TId id)
        {
            return await efRepository.DeleteAsync(id);
        }
        public virtual async Task UpdateRangeAsync(List<T> entities)
        {
            await efRepository.UpdateRangeAsync(entities);
        }
        public virtual async Task AddRangeAsync(List<T> entities)
        {
            entities.ForEach(entity =>
            {
                entity.CreatedDate = DateTime.Now;
                if (typeof(TId) == typeof(int))
                    entity.CreatedBy = (TId)(object)0;
                else
                    entity.CreatedBy = (TId)(object)Guid.NewGuid();
            });
            await efRepository.InsertRangeAsync(entities);
        }

        public virtual async Task<dynamic> ExecuteSQL(string qry)=> await efRepository.ExecuteSQL(qry);
    }
}
