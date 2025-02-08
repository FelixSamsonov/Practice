using Microsoft.AspNetCore.Identity;

namespace Webfirst.Models;

public class ApplicationUser : IdentityUser
{
    public required string FullName { get; set; }
}
