namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models;

    public class RentalEntityConfigurations : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder
                .HasOne(r => r.Car)
                .WithMany(r => r.Rentals)
                .HasForeignKey(r => r.CarId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(r => r.User)
                .WithMany(r => r.Rentals)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(r => r.IsPaid)
                .HasDefaultValue(false);

            builder
                .Property(c => c.IsDeleted)
                .HasDefaultValue(false);

            builder
                .Property(r => r.CreatedOn)
                .HasDefaultValue(DateTime.UtcNow);
        }
    }
}
