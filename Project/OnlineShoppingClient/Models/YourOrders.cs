using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingClient.Models
{
    [Table("YourOrders")]
    public class YourOrders
    {
        [Key]
        [Required]
        [Column(TypeName = "uniqueidentifier")]
        [ForeignKey("Order")]
        public Guid OrderId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MinLength(10), MaxLength(25)]
        public string? OrdrerAddress { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DeliveryDate { get; set; }


    }
}
