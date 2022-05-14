using Microsoft.AspNetCore.Identity;

namespace CoreIdentity.Models
{
    public class MyUser : IdentityUser<int>
    {
        public int MyUserId { get; set; }
        public string ImageUrl { get; set; }

    }
}
