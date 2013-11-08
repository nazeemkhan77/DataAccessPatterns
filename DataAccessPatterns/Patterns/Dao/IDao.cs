using System.Collections.Generic;

namespace Patterns.DataAccess.Dao
{
    interface IDao<TEntity, TId>
    {
        TEntity GetById(TId id);
        IList<TEntity> GetAll(TId id);
        void SaveOrUpdate(TEntity obj);
    }
}
