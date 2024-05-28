using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class YourOrdersServices:IYourOrdersServices
    {
        private readonly ProjectDbContext _dbContext;

        public YourOrdersServices(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public YourOrdersServices()
        //{
        //    _dbContext = new ProjectDbContext();
        //}

        public void Delete(string id)
        {
            try
            {
                YourOrders yourOrders = _dbContext.YourOrders.Find(id);
                _dbContext.YourOrders.Remove(yourOrders);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<YourOrders> GetAllyourOrders()
        {
            try
            {
                List<YourOrders> yourOrders = _dbContext.YourOrders.ToList();
                return yourOrders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public YourOrders GetYourOrderById(string id)
        {
            try
            {
                YourOrders yourOrders = _dbContext.YourOrders.Find("id");
                return yourOrders;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Add(YourOrders order)
        {
            try
            {
                _dbContext.YourOrders.Add(order);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
