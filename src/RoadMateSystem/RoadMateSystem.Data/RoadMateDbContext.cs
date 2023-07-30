namespace RoadMateSystem.Web.Data
{
    using System.Reflection;
    
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Data.Models.Payment;


    public class RoadMateDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public RoadMateDbContext(DbContextOptions<RoadMateDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<CarImage> CarImages { get; set; } = null!;  
        public DbSet<CarColor> Colors { get; set; } = null!;  
        public DbSet<Rental> Rentals { get; set; } = null!; 
        public DbSet<Review> Reviews { get; set; } = null!;
        public DbSet<Payment> Payment { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(RoadMateDbContext)) ??
                                      Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}