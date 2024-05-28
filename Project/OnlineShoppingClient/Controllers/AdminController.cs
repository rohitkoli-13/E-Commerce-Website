using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminServices _adminServices;

        public AdminController()
        {
            _adminServices = new AdminServices();
        }

        public IActionResult Index()
        {
            try
            {
                return RedirectToAction("Index", "Product");
            }
            catch (Exception ex)
            {

                return View("Error");  //Redirect to Error View
            }
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Login login)
        {
            Admin admin = _adminServices.Validate(login.UserName, login.Password);
            if (admin == null)
            {
                ViewBag.ErrorMsg = "Invalid Credentials";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("UserId", admin.AdminId);
                HttpContext.Session.SetString("UserName", admin.AdminName);
                return RedirectToAction("Index","Product");
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Admin admin)
        {
                 admin.AdminId="A"+new Random().Next(10000);
                _adminServices.Register(admin);
                return RedirectToAction("Login");
            
        }
        public IActionResult Delete(string id)
        {
                _adminServices.Delete(id);
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(string id)
        {
            Admin admin = _adminServices.GetAllAdmin().SingleOrDefault(i => i.AdminId == id);
            return View(admin);

        }
        [HttpPost]
        public IActionResult Edit(Admin admin)
        {
            _adminServices.Update(admin);
            return RedirectToAction("Index");
        }
    }
}
