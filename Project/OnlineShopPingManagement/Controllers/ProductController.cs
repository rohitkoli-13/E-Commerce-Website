using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        //public ProductController()
        //{
        //    _productServices = new ProductServices();
        //}
        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Product> products=_productServices.GetAll();
                return StatusCode(200, products);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet, Route("GetProduct/{id}")]
        public IActionResult GetProduct(string id)
        {
            try

            {
                Product product=_productServices.GetProduct(id);
                return StatusCode(200, product);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost, Route("Add")]
        public IActionResult Add(Product product)
        {
            try
            {
                _productServices.Add(product);
                return StatusCode(200, _productServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("Update")]
        public IActionResult Update(Product product)
        {
            try
            {
                _productServices.Update(product);
                return StatusCode(200, _productServices.GetAll());
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
                _productServices.Delete(id);
                return StatusCode(200, _productServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
