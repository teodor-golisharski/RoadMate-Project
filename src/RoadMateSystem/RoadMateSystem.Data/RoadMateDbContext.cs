namespace RoadMateSystem.Web.Data
{
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
            // Car entity
            builder.Entity<Car>()
                .Property(c => c.Drivetrain)
                .HasConversion<string>();

            builder.Entity<Car>()
                .Property(c => c.Fuel)
                .HasConversion<string>();

            builder.Entity<Car>()
                .Property(c => c.Type)
                .HasConversion<string>();

            builder.Entity<Car>()
                .Property(c => c.Transmission)
                .HasConversion<string>();

            // Payment entity
            builder.Entity<Payment>()
                .Property(p => p.PaymentMethod)
                .HasConversion<string>();
            

            base.OnModelCreating(builder);
        }
    }
}