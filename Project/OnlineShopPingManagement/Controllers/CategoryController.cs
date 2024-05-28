using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        //public CategoryController()
        //{
        //    _categoryServices = new CategoryServices();
        //}
        [HttpGet, Route("GetAll")]
        public IActionResult GetAll()
        {
            try
            {
                List<Category> categories = _categoryServices.GetAll();
                return StatusCode(200, categories);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpGet, Route("GetCategory/{id}")]
        public IActionResult GetCategory(string id)
        {
            try

            {
                Category category=_categoryServices.GetCategory(id);
                return StatusCode(200, category);
            }
            catch (Exception)
            {

                throw;
            }

        }
        [HttpPost, Route("Add")]
        public IActionResult Add(Category category)
        {
            try
            {
                _categoryServices.Add(category);
                return StatusCode(200, _categoryServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPut, Route("Update")]
        public IActionResult Update(Category category)
        {
            try
            {
                _categoryServices.Update(category);
                return StatusCode(200, _categoryServices.GetAll());
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
                _categoryServices.Delete(id);
                return StatusCode(200, _categoryServices.GetAll());
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
