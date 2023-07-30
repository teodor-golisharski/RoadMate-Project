namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;

    public class CarEntityConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasOne(c => c.Color)
                .WithMany(cc => cc.Cars)
                .HasForeignKey(c => c.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.ThumbnailImage)
                .WithOne(t => t.Car)
                .HasForeignKey<Car>(c => c.ThumbnailImageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Property(c => c.Drivetrain)
                .HasConversion<string>();
             
            builder
                .Property(c => c.Fuel)
                .HasConversion<string>();

            builder
                .Property(c => c.Type)
                .HasConversion<string>();

            builder
                .Property(c => c.Transmission)
                .HasConversion<string>();
        }
    }
}
