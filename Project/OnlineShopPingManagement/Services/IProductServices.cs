using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public interface IProductServices
    {
        public void Add(Product product);
        public void Update(Product product);
        public void Delete(string id);
        List<Product> GetAll();
        Product GetProduct(string id);
    }
}
