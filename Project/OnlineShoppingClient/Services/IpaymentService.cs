using Newtonsoft.Json;
using OnlineShoppingClient.Models;
using System.Net.Http.Headers;

namespace OnlineShoppingClient.Services
{
    public interface IpaymentService
    {
        public List<Payment> GetAllPayments();
        //public Payment GetPayment( string id);
        public void AddPayment(Payment payment);
    }
}
