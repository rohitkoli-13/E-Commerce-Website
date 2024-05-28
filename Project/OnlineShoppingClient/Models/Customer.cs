using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShoppingClient.Models
{
    [Table("CustomerDetails")]
    public class Customer
    {
        [Key]
        [StringLength(7)]
        public string CustomerId { get; set; } = "";
        [Required(ErrorMessage ="Enter name"),StringLength(50)]
        [Column(TypeName ="varchar")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Email is compulsory"), StringLength(50)]
         [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string? Mobile {  get; set; }
        [Required]
        [StringLength(50)]
        public string Address {  get; set; }
        [Required]
        [MinLength(8), MaxLength(16)]
        [PasswordPropertyText]
        public string Password {  get; set; }

    }
}
