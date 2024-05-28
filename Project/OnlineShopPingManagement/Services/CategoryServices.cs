using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class CategoryServices:ICategoryServices
    {

        private readonly ProjectDbContext _projectDbContext;

        public CategoryServices(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        //public CategoryServices() 
        //{
        //    _projectDbContext = new ProjectDbContext();
        //}

        public void Add(Category category)
        {
            try
            {
                _projectDbContext.Categories.Add(category);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Delete(string id)
        {
            try
            {
                Category category = _projectDbContext.Categories.Find(id);
                _projectDbContext.Categories.Remove(category);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> GetAll()
        {
            try
            {
                List<Category> categories = _projectDbContext.Categories.ToList();
                return categories;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category GetCategory(string id)
        {
            try
            {
                Category category = _projectDbContext.Categories.Find(id);
                return category;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Category category)
        {
            try
            {
                _projectDbContext.Categories.Update(category);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
