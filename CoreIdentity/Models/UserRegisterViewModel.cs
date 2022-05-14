using System.ComponentModel.DataAnnotations;

namespace CoreIdentity.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "please enter image url")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "please enter username")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "please enter re-password")]
        [Compare("Password", ErrorMessage = "passwords are not compatible")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "please enter mail")]
        public string Mail { get; set; }
    }
}
