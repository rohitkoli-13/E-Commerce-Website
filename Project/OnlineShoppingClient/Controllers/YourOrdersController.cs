using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class YourOrdersController : Controller
    {
        private readonly IYourOrdersServices _yourordersServices;

        public YourOrdersController()
        {
            _yourordersServices = new YourOrdersServices();
        }

        public IActionResult Index()
        {
            try
            {
                List<YourOrders> order = _yourordersServices.GetAllyourOrders();
                return View(order);
            }
            catch (Exception ex)
            {

                return View("Error");  //Redirect to Error View
            }
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(YourOrders order)
        {
            if (ModelState.IsValid)
            {
                _yourordersServices.Add(order);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                _yourordersServices.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
