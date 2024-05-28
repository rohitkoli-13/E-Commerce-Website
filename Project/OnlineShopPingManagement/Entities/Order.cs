using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Entities
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [StringLength(7)]
        [Column(TypeName = "varchar")]
        public string OrderId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [ForeignKey("ProductId")]
        public string? ProductId { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [ForeignKey("Customer")]
        public string? CustomerId { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime DeliveryDate { get; set; } = DateTime.Now.AddDays(6);
        [Required]
        [Column("Address",TypeName ="varchar")]
        [StringLength(50)]
        public string? DeliveryAddress {  get; set; }

      
         


    }
}
