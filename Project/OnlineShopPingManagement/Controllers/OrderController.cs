using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }

        //public OrderController()
        //{
        //    _orderServices = new OrderServices();
        //}
        [HttpPost,Route("Add")]
        public IActionResult Add(Order order)
        {
            try
            {
                _orderServices.Add(order);
                return StatusCode(200, _orderServices.GetAllOrders());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetAllOrders")]
        public IActionResult GetAllOrders()
        {
            try
            {
                return StatusCode(200, _orderServices.GetAllOrders());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet, Route("GetOrderById/{id}")]
        public IActionResult GetOrderById(string id)
        {
            try
            {
                Order order = _orderServices.GetOrderById(id);
                return StatusCode(200, order);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("Update/{id}")]
        public IActionResult Update(string id)
        {
            try
            {
                Order order = _orderServices.GetOrderById(id);
                _orderServices.Update(order);
                return StatusCode(200, order);
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
                _orderServices.Delete(id);
                return StatusCode(200, _orderServices.GetAllOrders());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
