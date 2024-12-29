using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models
{
    public class LoginViewModel
    {
        //Burasi, user'in girdigi email 
        [Required(ErrorMessage = "Username or Email is required.")]
        [MaxLength(20, ErrorMessage = "Max 20 characters.")]
        [DisplayName("Username or Email")]
        public string UserNameOrEmail { get; set; }

        //Burasi, user'in girdigi sifre temsili
        [Required(ErrorMessage = "Password  is required.")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "5-20 characters.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
