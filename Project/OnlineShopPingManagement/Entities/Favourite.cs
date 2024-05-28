using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingManagement.Entities
{
    public class Favourite
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string ProductId { get; set; }
        [Required(ErrorMessage = "Enter name"), StringLength(20)]
        [Column(TypeName = "varchar")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required!!")]
        [Column(TypeName = "decimal")]
        public double Price { get; set; }
        [Required]
        [Column(TypeName = "int")]
        public int Quantity { get; set; }
      
    }
}
