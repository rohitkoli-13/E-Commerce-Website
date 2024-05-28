using OnlineShoppingManagement.Entities;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly ProjectDbContext _context;

        public PaymentService(ProjectDbContext context)
        {
            _context = context;
        }

        //public PaymentService()
        //{
        //    _context = new ProjectDbContext();
        //}
        public void AddPayment(Payment payment)
        {
            try
            {
                _context.payments.Add(payment);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }     
        public List<Payment> GetAllPayments()
        {
            try
            {
                return _context.payments.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        } 
    }
}
