using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderServices _orderServices;

        public OrderController()
        {
            _orderServices = new OrderServices();
        }

        public IActionResult Index()
        {
            try
            {
                List<Order> order = _orderServices.GetAllOrders();
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
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _orderServices.Add(order);
                return RedirectToAction("Index");
            }
            else
                return View();
        }
        public IActionResult Delete(string id)
        {
            if (ModelState.IsValid)
            {
                _orderServices.Delete(id);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Edit(string id)
        {
            Order order = _orderServices.GetAllOrders().SingleOrDefault(i => i.CustomerId == id);
            return View(order);

        }
        [HttpPost]
        public IActionResult Edit(Order order)
        {
            _orderServices.Update(order);
            return RedirectToAction("Index");
        }
    }
}
