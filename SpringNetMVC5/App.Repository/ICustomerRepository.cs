using App.Repository.Mapping_EDMX;
using System.Linq;

namespace App.Repository
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllCustomer();
    }
}
