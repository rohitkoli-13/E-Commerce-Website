using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminServices _adminServices;

        public AdminController(IAdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        //public AdminController()
        //{
        //    _adminServices = new AdminServices();
        //}
        [HttpGet, Route("GetAllAdmins")]
        public IActionResult GetAllAdmins()
        {
            try
            {
                return StatusCode(200, _adminServices.GetAllAdmins());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetAdmin/{id}")]
        public IActionResult GetAdmin(string id)
        {
            try
            {
                Admin admin = _adminServices.GetAdmin(id);
                return StatusCode(200, admin);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("Register")]
        public IActionResult Register(Admin admin)
        {
            try
            {
                _adminServices.Register(admin);
                return StatusCode(200, admin);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("Validate/{email}/{password}")]
        public IActionResult Validate(string email, string password)
        {
            try
            {
                return StatusCode(200, _adminServices.Validate(email, password));
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("Update")]
        public IActionResult Update(Admin admin)
        {
            try
            {
                _adminServices.Update(admin);
                return StatusCode(200, admin);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpDelete, Route("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                _adminServices.Delete(id);
                return StatusCode(200, _adminServices.GetAllAdmins());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
