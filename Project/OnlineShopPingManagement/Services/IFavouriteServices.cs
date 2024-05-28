using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public interface IFavouriteServices
    {
        
        List<Favourite> GetAll();
        void Add(Favourite favourite);

        void Delete(string id);
    }
}
