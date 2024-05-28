using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace OnlineShoppingManagement.Entities
{
    [Table("AdminDetails")]
    public class Admin
    {
        [Required]
        [StringLength(6)]
        [Column(TypeName = "varchar")]
        public string? AdminId { get; set; } = "";
        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string? AdminName { get; set; }
        [Required]
        [StringLength(20)]
        [Column(TypeName = "varchar")]
        public string? AdminEmail { get; set; }
        [Required]
        [StringLength(10)]
        [Column(TypeName = "varchar")]
        [MinLength(8), MaxLength(16)]
        public string? AdminPassword { get; set; }


    }
}
