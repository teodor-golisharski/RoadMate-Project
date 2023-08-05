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
                .Property(p => p.Availability)
                .HasDefaultValue(true);

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

            //builder.HasData(this.GenerateCars());
        }

        private Car[] GenerateCars()
        {
            ICollection<Car> cars = new HashSet<Car>();

            // Renault Clio
            Car car;
            car = new Car()
            {
                Id = 1,
                CarMakeId = 1,
                Model = "Clio",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 4,
                Horsepower = 140,
                EngineCapacity = 1598,
                Seats = 5,
                Doors = 5,
                Description = "The car's advanced technology includes a user-friendly 9.3-inch touchscreen with the Easy Link system. It seamlessly integrates with Android Auto and Apple CarPlay, allowing you to access your favorite apps and stay connected on the go. The navigation system, powered by Google Maps and TomTom, ensures you'll never lose your way. " +
                "Enjoy a personalized driving experience with the customizable instrument cluster, which utilizes a TFT LCD display. The redesigned, compact steering wheel adds a touch of modernity to the cabin. " +
                "Renault Clio comes equipped with an array of impressive features. The electric parking brake enhances convenience, while the wireless smartphone charger keeps your device powered up without messy cables. The hands-free parking feature takes the stress out of parking in tight spots.",
                Availability = true,
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 52.99M,
                PricePerWeek = 319.99M
            };
            cars.Add(car);

            // Dacia Duster
            car = new Car()
            {
                Id = 2,
                CarMakeId = 2,
                Model = "Duster",
                Type = CarType.SUV,
                Fuel = FuelType.Diesel,
                ColorId = 1,
                Horsepower = 115,
                EngineCapacity = 1461,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Manual,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 45.99M,
                PricePerWeek = 279.99M
            };
            cars.Add(car);

            // Ford Fiesta
            car = new Car()
            {
                Id = 3,
                CarMakeId = 3,
                Model = "Fiesta",
                Type = CarType.Hatchback,
                Fuel = FuelType.Gasoline,
                ColorId = 2,
                Horsepower = 200,
                EngineCapacity = 1496,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 59.99M,
                PricePerWeek = 374.99M
            };
            cars.Add(car);

            // Honda Jazz
            car = new Car()
            {
                Id = 4,
                CarMakeId = 4,
                Model = "Jazz",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 1,
                Horsepower = 122,
                EngineCapacity = 1498,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 49.99M,
                PricePerWeek = 289.99M
            };
            cars.Add(car);

            // Peugeot 308
            car = new Car()
            {
                Id = 5,
                CarMakeId = 5,
                Model = "308",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 1,
                Horsepower = 220,
                EngineCapacity = 1598,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 61.99M,
                PricePerWeek = 384.99M
            };
            cars.Add(car);

            // Skoda Fabia
            car = new Car()
            {
                Id = 7,
                CarMakeId = 7,
                Model = "Golf",
                Type = CarType.Hatchback,
                Fuel = FuelType.Gasoline,
                ColorId = 1,
                Horsepower = 115,
                EngineCapacity = 1461,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Manual,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 45.99M,
                PricePerWeek = 269.99M
            };
            cars.Add(car);

            // Volkswagen Golf
            car = new Car()
            {
                Id = 6,
                CarMakeId = 6,
                Model = "",
                Type = CarType.Hatchback,
                Fuel = FuelType.Gasoline,
                ColorId = 1,
                Horsepower = 115,
                EngineCapacity = 1461,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Availability = true,
                Transmission = Transmission.Manual,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 45.99M,
                PricePerWeek = 269.99M
            };
            cars.Add(car);

            return cars.ToArray();
        }
    }
}
