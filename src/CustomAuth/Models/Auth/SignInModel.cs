using System.ComponentModel.DataAnnotations;

namespace CustomAuth.Models.Auth
{
    public class SignInModel
    {
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
