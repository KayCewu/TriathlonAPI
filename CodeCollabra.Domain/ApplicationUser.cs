using Microsoft.AspNetCore.Identity;

namespace CodeCollabra.Domain
{
    public class ApplicationUser:IdentityUser
    {
        public string PasswordHash { get; set; }
    }
}
