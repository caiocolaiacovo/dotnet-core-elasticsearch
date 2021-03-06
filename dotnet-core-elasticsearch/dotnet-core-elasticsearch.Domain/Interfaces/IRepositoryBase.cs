using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace dotnet_core_elasticsearch.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {

        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(TEntity entities);
    }
}