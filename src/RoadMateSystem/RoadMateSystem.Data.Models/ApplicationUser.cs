using Microsoft.AspNetCore.Identity;

namespace RoadMateSystem.Data.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; } = null!;
        
        public string LastName { get; set; } = null!;
        
        public string Password { get; set; } = null!;
        
        public string Phone { get; set; } = null!;
        
        public string Address { get; set; } = null!;
    }
}
