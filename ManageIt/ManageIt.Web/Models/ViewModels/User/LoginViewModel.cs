using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ManageIt.Web.Models.ViewModels.User
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Hasło")]
        public string Password { get; set; }
    }
}
