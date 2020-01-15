﻿using BreakingNews.Application.Interfaces;
using BreakingNews.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BreakingNews.Application.AppServices
{
    public class AppServiceBase<TEntity> : IAppServiceBase<TEntity> where TEntity : class
    {
        IServiceBase<TEntity> _service;

        public AppServiceBase(IServiceBase<TEntity> service)
        {
            _service = service;
        }

        public async Task AddAsync(TEntity obj)
        {
            await _service.AddAsync(obj);
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _service.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _service.GetByIdAsync(id);
        }

        public async Task<IEnumerable<TEntity>> QueryAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _service.QueryAsync(predicate);
        }

        public async Task RemoveAsync(TEntity obj)
        {
            await _service.RemoveAsync(obj);
        }

        public async Task UpdateAsync(TEntity obj)
        {
            await _service.UpdateAsync(obj);
        }
    }
}
