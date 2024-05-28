using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public interface IYourOrdersServices
    {
        YourOrders GetYourOrderById(string id);
        List<YourOrders> GetAllyourOrders();
        void Add(YourOrders order);
        void Delete(string id);
    }
}
