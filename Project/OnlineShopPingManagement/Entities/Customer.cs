using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShopPingManagement.Entities
{
    [Table("CustomerDetails")]
    public class Customer
    {
        [Key]
        [Column(TypeName ="varchar")]
        [StringLength(7)]

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CustomerId {  get; set; }
        [Required(ErrorMessage ="Enter name"),StringLength(50)]
        [Column(TypeName ="varchar")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Email is compulsory"), StringLength(50)]
        [Column(TypeName = "varchar")]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string? Mobile {  get; set; }
        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        public string Address {  get; set; }
        [Required]
        [Column(TypeName = "varchar")]
        [MinLength(8), MaxLength(16)]
        [PasswordPropertyText]
        public string Password {  get; set; }

    }
}
