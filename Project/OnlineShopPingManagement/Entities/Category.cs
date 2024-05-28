using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingManagement.Entities
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [Column(TypeName = "varchar")]
        [StringLength(6)]
        public string CategoryId { get; set; }
        [Required]
        [StringLength(20)]
        public string? CategoryName { get; set; }
    }
}
