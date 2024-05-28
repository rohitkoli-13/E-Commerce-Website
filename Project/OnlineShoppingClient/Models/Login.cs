using System.ComponentModel.DataAnnotations;
namespace OnlineShoppingClient.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Please Enter Username")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Please Enter Password")]
        public string Password { get; set; }
    }
}
