using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using OnlineShopPingManagement.Entities;

namespace OnlineShoppingManagement.Entities
{
    [Table("Transactions")]
    public class Payment
    {
        [Key]
        [Column(TypeName="uniqueidentifier")]
        public Guid PaymentId { get; set; }= Guid.NewGuid();


        [Required]       
        [Column(TypeName = "DateTime")]
        public DateTime PaymentDate { get; set; }

        [Required]
        [StringLength(7)]
        [Column(TypeName = "varchar")]
        [ForeignKey("Order")]
        public string OrderId {  get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "Varchar")]

        public string PaymentType { get; set; }
        public Order Order { get; set; }
    }
}
