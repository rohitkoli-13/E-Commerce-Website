using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryServices _services;
        public CategoryController()
        {
            _services = new CategoryServices();
        }
        public IActionResult Index()
        {
            List<Category> categories = _services.GetAll();
            return View(categories);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.CategoryId = "C" + new Random().Next(100000);

                _services.Add(category);
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
            Category category = _services.GetAll().SingleOrDefault(u => u.CategoryId == id);
            return View(category);
        }
        [HttpPost]
        public IActionResult Update(Category category)
        {
            _services.Update(category);
            return RedirectToAction("Index");


        }
        public IActionResult GetCategory(string id)
        {
            Category category = _services.GetAll().SingleOrDefault(p => p.CategoryId == id);
            return View(category);
        }
    }
}
