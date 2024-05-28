using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineShoppingClient.Models;

namespace OnlineShoppingClient.Models
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [Required]
        [Column(TypeName = "uniqueidentifier")]
        public Guid OrderId { get; set; }= Guid.NewGuid();
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
        [Column("Address",TypeName ="nvarchar")]
        [StringLength(50)]
        public string? DeliveryAddress {  get; set; }

      
         


    }
}
