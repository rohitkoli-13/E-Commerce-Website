using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Services;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerServices _customerServices;

        public CustomerController(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        //public CustomerController()
        //{
        //    _customerServices = new CustomerServices();
        //}
        [HttpGet,Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Customer> customers = _customerServices.GetAll();
                return StatusCode(200, customers);
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpGet,Route("GetCustomer/{id}")]
        public IActionResult GetCustomer(string id)
        {
            try
            {
                Customer customer = _customerServices.GetCustomer(id);
                return StatusCode(200, customer);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpPost,Route("Registration")]
        public IActionResult Registration(Customer customer)
        {
            try
            {
                _customerServices.Registraion(customer);
                return StatusCode(200, _customerServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPut,Route("Update")]
        public IActionResult Update(Customer customer)
        {
            try
            {
                _customerServices.Update(customer);
                return StatusCode(200,_customerServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete,Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _customerServices.Delete(id);
                return StatusCode(200, _customerServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("Validate/{Email}/{Password}")]
        public IActionResult Validate(string Email,string Password)
        {
            try
            {
                Customer customer = _customerServices.Validate(Email, Password);
                return StatusCode(200,customer);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
