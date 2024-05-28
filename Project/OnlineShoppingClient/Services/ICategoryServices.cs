using OnlineShoppingClient.Models;

namespace OnlineShoppingClient.Services
{
    public interface ICategoryServices
    {
        public void Add(Category category);
        public void Update(Category category);
        public void Delete(string id);
        List<Category> GetAll();
        Category GetCategory(string id);
    }
}
