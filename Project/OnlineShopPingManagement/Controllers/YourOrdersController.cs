using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class YourOrdersController : ControllerBase
    {
        private readonly IYourOrdersServices _yourOrders;

        public YourOrdersController(IYourOrdersServices yourOrders)
        {
            _yourOrders = yourOrders;
        }

        //public YourOrdersController()
        //{
        //    _yourOrders = new YourOrdersServices();
        //}
        [HttpGet, Route("GetAllyourOrder")]
        public IActionResult GetAllyourOrder()
        {
            try
            {
                return StatusCode(200, _yourOrders.GetAllyourOrders());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetYourOrderById/{id}")]
        public IActionResult GetYourOrderById(string id)
        {
            try
            {
                YourOrders yourOrders = _yourOrders.GetYourOrderById(id);
                return StatusCode(200, yourOrders);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost, Route("Add/{id}")]
        public IActionResult Add(YourOrders yourOrders)
        {
            try
            {
                
                _yourOrders.Add(yourOrders);
                return StatusCode(200, _yourOrders.GetAllyourOrders());
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
                _yourOrders.Delete(id);
                return StatusCode(200, _yourOrders.GetAllyourOrders());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
