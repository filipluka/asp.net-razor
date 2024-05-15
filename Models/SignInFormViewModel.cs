using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP.NETCore_RazorPages.Models
{
    public class SignInFormViewModel
    {
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Invalid email address")]
        public string Email { get; set; } = null;

        [DataType(DataType.Password)]
        [DisplayName("Password")]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; } = null;

        [DisplayName("Remember me")]
        public bool RememberMe { get; set; }
    }
}
