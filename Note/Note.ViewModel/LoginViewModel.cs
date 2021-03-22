using System.ComponentModel.DataAnnotations;

namespace Note.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string UserPassword { get; set; }
    }
}
