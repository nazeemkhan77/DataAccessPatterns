using System.Collections.Generic;

namespace Patterns.DataAccess.Repository
{
    interface IRepository<TEntity, TId>
    {
        TEntity GetById(TId id);
        IList<TEntity> GetAll(TId id);
        void SaveOrUpdate(TEntity obj);
    }

    interface ITransaction
    {
        void Begin();
        void Commit();
        void Rollback();
    }
}
