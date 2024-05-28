using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductServices _services;
        public ProductController()
        {
            _services = new ProductServices();
        }
        public IActionResult Index()
        {
            List<Product> products = _services.GetAll();
            return View(products);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.ProductId = "P" + new Random().Next(100000);
                _services.Add(product);
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
            Product product = _services.GetAll().SingleOrDefault(u => u.ProductId == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Update(Product product)
        {
            _services.Update(product);
            return RedirectToAction("Index");


        }
        public IActionResult GetProduct(string id)
        {
            Product product = _services.GetAll().SingleOrDefault(p => p.ProductId == id);
            return View(product);
        }
       
        public IActionResult AddFavourite(string id)
        {
            Product product = _services.GetAll().SingleOrDefault(p => p.ProductId == id);
            return RedirectToAction("Create", "Favourite", product);
        }
        //public IActionResult OrderProduct(string id)
        //{
        //    Product product = _services.GetAll().SingleOrDefault(p => p.ProductId == id);
        //    return RedirectToAction("Create", "Order", product);
        //}

    }
}
