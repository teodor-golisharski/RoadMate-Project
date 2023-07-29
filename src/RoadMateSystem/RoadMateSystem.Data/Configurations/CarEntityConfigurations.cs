namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;

    public class CarEntityConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            throw new NotImplementedException();
        }
    }
}
