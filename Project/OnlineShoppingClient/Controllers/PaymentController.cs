
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingClient.Models;
using OnlineShoppingClient.Services;

namespace OnlineShoppingClient.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IpaymentService _paymentService;

        public PaymentController()
        {
            _paymentService=new PaymentService();
        }
        public IActionResult Index()
        {
            try
            {
                List<Payment> payments = _paymentService.GetAllPayments();
                return View(payments);
                
            }
            catch (Exception ex)
            {
                return View("Error");


            }
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Payment payment) 
        {
            _paymentService.AddPayment(payment);
            return RedirectToAction("Index");
           
        }

        


    }
}
