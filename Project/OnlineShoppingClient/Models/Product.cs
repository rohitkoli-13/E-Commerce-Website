using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingClient.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string ProductId { get; set; } = "";
        [Required(ErrorMessage = "Enter name"), StringLength(20)]
        [Column(TypeName = "varchar")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Category is compulsory")]
        [Column(TypeName = "varchar"), StringLength(6)]
        [ForeignKey("CategoryId")]
        public string CategoryId { get; set; }
        [Required(ErrorMessage ="Price is required!!")]
        [Column(TypeName = "decimal")]
        public double Price {  get; set; }
        [Required]
        [Column(TypeName ="int")]
        public int Stock {  get; set; }
        [Required]
        [StringLength(100),Column(TypeName ="varchar")]
        public string Description {  get; set; }



    }
}
