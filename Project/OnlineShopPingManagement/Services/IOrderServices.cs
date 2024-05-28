using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public interface IOrderServices
    {
        void Add(Order order);
        Order GetOrderById(string id);
        List<Order> GetAllOrders();
        void Update(Order order);
        void Delete(string id);
    }
}
