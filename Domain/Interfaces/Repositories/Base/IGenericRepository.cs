﻿using Domain.Aggregates;
using Domain.Interfaces.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories.Base
{
    public interface IGenericRepository<TModel>
        where TModel : class, IEntity
    {
        Task<TEntity?> Get<TEntity>(Expression<Func<TEntity, bool>> expression);

        Task<PagedResult<TEntity>> PagedList<TEntity>(Expression<Func<TEntity, bool>>? expression, int pageNumber, int pageSize);

        Task<List<TGenericDTO>> List<TGenericDTO>(TGenericDTO expression) where TGenericDTO : class;

        Task<int> Count<TEntity>(Expression<Func<TEntity, bool>>? expression = null);

        Task<bool> Exist<TEntity>(Expression<Func<TEntity, bool>> expression);

        Task<IAutoGeneratedValue> Insert(TModel model);

        Task Update<TEntity>(TEntity entity);

        Task Delete<TEntity>(int id);
    }

    public interface IAutoGeneratedValue
    {
        int Value { get; }
    }
}
