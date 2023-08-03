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
                .HasOne(c => c.CarMake)
                .WithMany(cc => cc.Cars)
                .HasForeignKey(c => c.CarMakeId)
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

            // Seeding
            builder.HasData(this.GenerateCarMakes());

            builder.HasData(this.GenerateCarColors());
        }

        private CarMake[] GenerateCarMakes()
        {
            ICollection<CarMake> carMakes = new HashSet<CarMake>();

            CarMake carMake;

            carMake = new CarMake() 
            { 
                Id = 1,
                Make = "Renault"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 2,
                Make = "Dacia"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 3,
                Make = "Ford"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 4,
                Make = "Honda"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 5,
                Make = "Peugeot"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 6,
                Make = "Skoda"
            };
            carMakes.Add(carMake);
            
            carMake = new CarMake()
            {
                Id = 7,
                Make = "Volkswagen"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 8,
                Make = "Toyota"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 9,
                Make = "Mazda"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 10,
                Make = "BMW"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 11,
                Make = "Audi"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 12,
                Make = "Mercedes-Benz"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 13,
                Make = "Porsche"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 14,
                Make = "Range Rover"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 15,
                Make = "Maserati"
            };
            carMakes.Add(carMake);

            return carMakes.ToArray();
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
                Hex = " #D9D9D9"
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

            carColor = new CarColor()
            {
                Id = 8,
                Name = "Green",
                Hex = "008000"
            };
            carColors.Add(carColor);

            return carColors.ToArray();
        }
    }
}
