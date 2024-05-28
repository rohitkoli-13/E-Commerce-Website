using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class ProductServices : IProductServices
    {
        private readonly ProjectDbContext _projectDbContext;

        public ProductServices(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        //public ProductServices()
        //{
        //    _projectDbContext = new ProjectDbContext();
        //}
        public void Add(Product product)
        {
            try
            {
                _projectDbContext.Products.Add(product);
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
                Product product = _projectDbContext.Products.Find(id);
                _projectDbContext.Products.Remove(product);
                _projectDbContext.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Product> GetAll()
        {
            try
            {
                List<Product> products = _projectDbContext.Products.ToList();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Product GetProduct(string id)
        {
            try
            {
                return _projectDbContext.Products.Find(id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Product product)
        {
            try
            {
                _projectDbContext.Products.Update(product);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
