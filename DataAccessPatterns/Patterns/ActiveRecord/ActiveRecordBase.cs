using System.Collections.Generic;

namespace Patterns.DataAccess.ActiveRecord
{
    public abstract class ActiveRecordBase<TEntity, TId>
    {
        public TEntity GetById(TId id)
        {
            return default(TEntity);
        }

        public IList<TEntity> GetAll(TId id)
        {
            return default(IList<TEntity>);
        }

        public void SaveOrUpdate(TEntity obj)
        {
        }
    }
}
