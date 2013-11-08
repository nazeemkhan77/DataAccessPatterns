using System;
using System.Collections.Generic;

namespace Patterns.DataAccess.Repository
{
    public class Repository<TEntity, TId> : IRepository<TEntity, TId>
    {
        public TEntity GetById(TId id)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> GetAll(TId id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
