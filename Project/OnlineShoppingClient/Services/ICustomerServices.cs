using OnlineShoppingClient.Models;

namespace OnlineShoppingClient.Services
{
    public interface ICustomerServices
    {
        void Registraion(Customer customer);
        void Update(Customer customer);
        void Delete(string id);
        List<Customer> GetAll();
        Customer GetCustomer(string id);
        Customer Validate(string email, string password);
    }
}
