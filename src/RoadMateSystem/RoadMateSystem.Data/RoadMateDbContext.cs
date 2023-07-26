using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoadMateSystem.Data.Models;

namespace RoadMateSystem.Web.Data
{
    public class RoadMateDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public RoadMateDbContext(DbContextOptions<RoadMateDbContext> options)
            : base(options)
        {
        }
    }
}