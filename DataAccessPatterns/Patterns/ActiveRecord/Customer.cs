using Patterns.DataAccess.Model;

namespace Patterns.DataAccess.ActiveRecord
{
    public class Customer : ActiveRecordBase<Customer, int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
}
