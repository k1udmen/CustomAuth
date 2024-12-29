using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Entities
{
    [Index(nameof(Email),IsUnique = true )]
    [Index(nameof(UserName), IsUnique = true)]

    //Bu sınıf sistemdeki kullanıcı hesaplarını temsil eden  özellikleri içermekte
    public class UserAccount
    {

        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage ="First name is required.")]
        [MaxLength(50,ErrorMessage ="Max 50 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(50, ErrorMessage = "Max 50 characters.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email  is required.")]
        [MaxLength(100, ErrorMessage = "Max 100 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is required.")]
        [MaxLength(20, ErrorMessage = "Max 20 characters.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password  is required.")]
        [MaxLength(20, ErrorMessage = "Max 20 characters.")]
        public string Password { get; set; }



    }
}
