namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;

    public class CarColorEntityConfiguration : IEntityTypeConfiguration<CarColor>
    {
        public void Configure(EntityTypeBuilder<CarColor> builder)
        {
            builder.HasData(GenerateCarColors());
        }

        private CarColor[] GenerateCarColors()
        {
            ICollection<CarColor> carColors = new HashSet<CarColor>();

            CarColor carColor;

            carColor = new CarColor()
            {
                Id = 1,
                Name = "White",
                Hex = "#FFFFFF"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 2,
                Name = "Black",
                Hex = "#000000"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 3,
                Name = "Silver",
                Hex = "#D9D9D9"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 4,
                Name = "Blue",
                Hex = "#003399"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 5,
                Name = "Grey",
                Hex = "#737373"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 6,
                Name = "Red",
                Hex = "B30000"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 7,
                Name = "Orange",
                Hex = "FF9900"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 8,
                Name = "Green",
                Hex = "008000"
            };
            carColors.Add(carColor);

            carColor = new CarColor()
            {
                Id = 9,
                Name = "Yellow",
                Hex = "#FFE800"
            };
            carColors.Add(carColor);

            return carColors.ToArray();
        }

    }
}
