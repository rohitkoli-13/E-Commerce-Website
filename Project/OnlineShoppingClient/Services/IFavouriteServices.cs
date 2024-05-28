using OnlineShoppingClient.Models;

namespace OnlineShoppingClient.Services
{
    public interface IFavouriteServices
    {
        List<Favourite> GetAll();
        void Add(Favourite favourite);

        void Delete(string id);
    }
}
