using OnlineShoppingManagement.Entities;

namespace OnlineShoppingManagement.Services
{

    public interface IPaymentService
    {
        public List<Payment> GetAllPayments();
        //public Payment GetPayment( string id);
        public void AddPayment(Payment payment);

        //public void DeletePayment(int id);
    }
}
