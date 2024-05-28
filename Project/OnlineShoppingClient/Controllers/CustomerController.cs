using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerServices _services;
        public CustomerController()
        {
            _services = new CustomerServices();
        }
        public IActionResult Index()
        {
            List<Customer> customers=_services.GetAll();
            return View(customers);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if(ModelState.IsValid)
            {
                customer.CustomerId = "C" + new Random().Next(100000);
                _services.Registraion(customer);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                _services.Delete(id);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Update(string id)
        {
            Customer customer=_services.GetAll().SingleOrDefault(u => u.CustomerId == id);
            return View(customer);
        }
        [HttpPost]
        public IActionResult Update(Customer customer)
        {
           _services.Update(customer);
                return RedirectToAction("Index");
         

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    Customer customer= _services.Validate(login.UserName, login.Password);
                    if (customer == null)
                    {
                        ViewBag.ErrorMsg = "Invalid Credential";
                        return View();
                    }
                    else 
                    {   

                            return RedirectToAction("Index");
                    
                    }


                }
                else
                    return View();
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}
