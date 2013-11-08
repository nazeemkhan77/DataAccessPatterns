using System.Collections.Generic;
using Patterns.DataAccess.Model;

namespace Patterns.DataAccess.Dao
{
    public class AddressDao : IDao<Address, int>
    {
        public Address GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Address> GetAll(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveOrUpdate(Address obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
