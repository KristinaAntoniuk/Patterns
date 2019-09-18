using App.Repository;
using System.Web.Mvc;

namespace SpringNetMVC5.Controllers
{
    public class CustomerController : Controller
    {
        public ICustomerRepository CustomerRepository { get; set; }

        // GET: Customer  
        public ActionResult Index()
        {
            var customerList = CustomerRepository.GetAllCustomer();

            return View(customerList);
        }
    }
}