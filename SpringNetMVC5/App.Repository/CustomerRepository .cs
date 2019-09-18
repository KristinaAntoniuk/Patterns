using System.Linq;
using App.Repository.Mapping_EDMX;

namespace App.Repository
{
    class CustomerRepository : ICustomerRepository
    {
        DBCustomerEntities db = new DBCustomerEntities();

        public IQueryable<Customer> GetAllCustomer()
        {
            return db.Customers.AsQueryable();
        }
    }
}
