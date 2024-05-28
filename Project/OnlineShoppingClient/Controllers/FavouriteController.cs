using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class FavouriteController : Controller
    {
        private readonly IFavouriteServices _services;
        public FavouriteController()
        {
            _services = new FavouriteServices();
        }
        public IActionResult Index()
        {
            List<Favourite> favourites  = _services.GetAll();
            return View(favourites);
        }
        public IActionResult Create(Product product)
        {
                
                Favourite favourite = new Favourite();
                favourite.ProductId = product.ProductId;
                favourite.ProductName = product.ProductName;
                favourite.Price = product.Price;
                favourite.Quantity = 1;
                _services.Add(favourite);
                return RedirectToAction("Index");
          
        }
        public IActionResult Delete(string id)
        {
           
                _services.Delete(id);
                return RedirectToAction("Index");
            
        }
       
    }
}
