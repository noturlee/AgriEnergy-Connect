using System.ComponentModel.DataAnnotations;

namespace FireBasics.Models
{
    public class AuthModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public DateOnly? Dob { get; set; }

        [Required]
        public string? Bio { get; set; }
    }
}
