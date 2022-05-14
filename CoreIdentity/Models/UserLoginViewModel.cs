using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIdentity.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "please enter username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "please enter password")]
        public string Password { get; set; }
    }
}
