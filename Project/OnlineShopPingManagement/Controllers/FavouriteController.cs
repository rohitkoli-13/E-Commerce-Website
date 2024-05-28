using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private readonly IFavouriteServices _favouriteServices;

        public FavouriteController(IFavouriteServices favouriteServices)
        {
            _favouriteServices = favouriteServices;
        }

        //public FavouriteController()
        //{
        //    _favouriteServices = new FavouriteServices();
        //}
        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Favourite> favourites = _favouriteServices.GetAll();
                return StatusCode(200, favourites);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost, Route("Add")]
        public IActionResult Add(Favourite favourite)
        {
            try
            {
                _favouriteServices.Add(favourite);
                return StatusCode(200, _favouriteServices.GetAll());
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
                _favouriteServices.Delete(id);
                return StatusCode(200, _favouriteServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }


    }

}
