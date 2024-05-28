using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace OnlineShoppingClient.Models
{
    [Table("AdminDetails")]
    public class Admin
    {
        [Required]
        [StringLength(6)]
        public string? AdminId { get; set; } = "";
        [Required]
        [StringLength(20)]
        public string? AdminName { get; set; }
        [Required]
        [StringLength(20)]
        [EmailAddress]
        public string? AdminEmail { get; set; }
        [Required]
        [StringLength(10)]
        [MinLength(8), MaxLength(16)]
        [PasswordPropertyText]
        public string? AdminPassword { get; set; }


    }
}
