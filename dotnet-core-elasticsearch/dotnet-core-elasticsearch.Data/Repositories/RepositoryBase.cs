using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using dotnet_core_elasticsearch.Data.Context;
using dotnet_core_elasticsearch.Domain.Interfaces;

namespace dotnet_core_elasticsearch.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected EFContext context = new EFContext();
        
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(TEntity entities)
        {
            throw new NotImplementedException();
        }
    }
}