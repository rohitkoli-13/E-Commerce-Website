using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly ProjectDbContext _projectDbContext;

        public CustomerServices(ProjectDbContext projectDbContext)
        {
            _projectDbContext = projectDbContext;
        }

        //public CustomerServices()
        //{
        //    _projectDbContext = new ProjectDbContext();
        //}
        public void Delete(string Id)
        {
            try
            {
                Customer customer= _projectDbContext.Customers.Find(Id);
                _projectDbContext.Customers.Remove(customer);
                _projectDbContext.SaveChanges();
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Customer> GetAll()
        {

            List<Customer> customers = _projectDbContext.Customers.ToList();
            
            return customers;
        }

        public Customer GetCustomer(string id)
        {
            Customer customer = _projectDbContext.Customers.Find(id);
            return customer;
        }

        public void Registraion(Customer customer)
        {
            try
            {
                _projectDbContext.Customers.Add(customer);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
              

        }

        public void Update(Customer customer)
        {
            try
            {
                _projectDbContext.Customers.Update(customer);
                _projectDbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Customer Validate(string email, string password)
        {
            try
            {
                Customer customer = _projectDbContext.Customers.SingleOrDefault(c => c.Email == email && password == c.Password);
                return customer;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
