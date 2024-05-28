using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
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
