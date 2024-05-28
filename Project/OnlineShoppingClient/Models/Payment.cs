using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingClient.Models
{
    public class Payment
    {

        public Guid PaymentId { get; set; } = Guid.NewGuid();


        public DateTime PaymentDate { get; set; }


        public string OrderId { get; set; }


        public string PaymentType { get; set; }
    }
}
