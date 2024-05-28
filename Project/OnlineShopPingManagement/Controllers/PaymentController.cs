using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingManagement.Entities;
using OnlineShoppingManagement.Services;

namespace OnlineShoppingManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        //public PaymentController()
        //{
        //   paymentService= new PaymentService();
        //}

        [HttpGet, Route("GetPayments")]
        public IActionResult GetAll()
        {
            try
            {
                return StatusCode(200, paymentService.GetAllPayments());
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost, Route("AddPayment")]

        public IActionResult AddPayment(Payment payment)
        {
            try
            {
                paymentService.AddPayment(payment);
                return StatusCode(200, payment);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
