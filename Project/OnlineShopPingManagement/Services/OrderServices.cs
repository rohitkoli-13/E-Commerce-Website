using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class OrderServices:IOrderServices
    {
        private readonly ProjectDbContext _projectdbContext;

        public OrderServices(ProjectDbContext projectdbContext)
        {
            _projectdbContext = projectdbContext;
        }

        //public OrderServices()
        //{
        //    _projectdbContext = new ProjectDbContext();
        //}
        public void Add(Order order)
        {
            try
            {
                _projectdbContext.Orders.Add(order);
                _projectdbContext.SaveChanges();
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
                Order order = _projectdbContext.Orders.Find(id);
                _projectdbContext.Orders.Remove(order);
                _projectdbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Order> GetAllOrders()
        {
            try
            {
                List<Order> orders = _projectdbContext.Orders.ToList();
                return orders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Order GetOrderById(string id)
        {
            try
            {
                Order order = _projectdbContext.Orders.Find(id);
                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Order order)
        {
            _projectdbContext.Orders.Update(order);
            _projectdbContext.SaveChanges();
        }
    }
}
