using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public interface IYourOrdersServices
    {
        YourOrders GetYourOrderById(string id);
        List<YourOrders> GetAllyourOrders();
        void Delete(string id);
        void Add(YourOrders order);
    }
}
