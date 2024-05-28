using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingClient.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]
        [StringLength(6)]
        public string CategoryId { get; set; } = "";
        [Required]
        [StringLength(20)]
        public string? CategoryName { get; set; }
    }
}
