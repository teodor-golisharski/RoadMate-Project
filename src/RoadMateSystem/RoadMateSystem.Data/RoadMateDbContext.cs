namespace RoadMateSystem.Web.Data
{
    using System.Reflection;
    
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Data.Models.Car;


    public class RoadMateDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        private readonly bool seedDb;
        public RoadMateDbContext(DbContextOptions<RoadMateDbContext> options, bool seedDb = true)
            : base(options)
        {
            this.seedDb = seedDb;
        }

        public DbSet<Car> Cars { get; set; } = null!;
        public DbSet<CarMake> CarMakes { get; set; } = null!;
        public DbSet<CarImage> CarImages { get; set; } = null!; 
        public DbSet<CarColor> Colors { get; set; } = null!;  
        public DbSet<Rental> Rentals { get; set; } = null!; 
        public DbSet<Review> Reviews { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            Assembly configAssembly = Assembly.GetAssembly(typeof(RoadMateDbContext)) ??
                                      Assembly.GetExecutingAssembly();

            builder.ApplyConfigurationsFromAssembly(configAssembly);

            base.OnModelCreating(builder);
        }
    }
}