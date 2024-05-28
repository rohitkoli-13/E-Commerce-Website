using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingManagement.Entities
{
    [Table("YourOrders")]
    public class YourOrders
    {
        [Key]
        [StringLength(7)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Order")]
        public string OrderId { get; set; } = "";
        [Required]
        [Column(TypeName = "varchar")]
        [MinLength(10), MaxLength(25)]
        public string? OrdrerAddress { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime DeliveryDate { get; set; }

        public Order? Order { get; set; }

    }
}
