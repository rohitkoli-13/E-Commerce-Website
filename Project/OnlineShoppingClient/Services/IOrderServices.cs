using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public interface IOrderServices
    {
        Order GetOrderById(string id);
        List<Order> GetAllOrders();
        void Update(Order order);
        void Delete(string id);
        void Add(Order order);      
    }
}
