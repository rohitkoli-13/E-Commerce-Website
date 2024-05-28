using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingClient.Models
{
    public class Favourite
    {
        [Key]
        [StringLength(6)]
        public string ProductId { get; set; } = "";
        [Required(ErrorMessage = "Enter name"), StringLength(20)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Price is required!!")]
        [Column(TypeName = "decimal")]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
      
    }
}
