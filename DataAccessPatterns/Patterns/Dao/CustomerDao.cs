using System;
using System.Collections.Generic;
using Patterns.DataAccess.Model;

namespace Patterns.DataAccess.Dao
{
    class CustomerDao : ICustomerDao
    {
        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveOrUpdate(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
