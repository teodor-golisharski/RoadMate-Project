namespace RoadMateSystem.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static RoadMateSystem.Data.Models.Car.Car;

    public class CarServiceTests
    {
        private DbContextOptions<RoadMateDbContext> dbOptions;
        private RoadMateDbContext dbContext;


        [Test]
        public async Task AllAsync_ShouldReturnExpectedResult()
        {
            var dbContextOptions = new DbContextOptionsBuilder<RoadMateDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var dbContext = new RoadMateDbContext(dbContextOptions))
            {
                dbContext.Cars.Add(new Car()
                {
                    Id = 499,
                    CarMakeId = 10,
                    Model = "120d",
                    Type = CarType.Hatchback,
                    Fuel = FuelType.Diesel,
                    ColorId = 3,
                    Horsepower = 190,
                    EngineCapacity = 1995,
                    Seats = 5,
                    Doors = 5,
                    Description = "The BMW 120d F40 is a sporty and dynamic compact luxury car that exudes performance and sophistication. In its base model, the BMW 120d comes equipped with a powerful 2.0-liter TwinPower Turbo diesel engine, providing impressive acceleration and fuel efficiency. " +
               "The interior features premium materials and the latest BMW iDrive infotainment system with an intuitive 8.8-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
               "BMW 120d is equipped with luxurious leather upholstery, a panoramic sunroof for an airy cabin ambiance, and a Harman Kardon premium sound system for an immersive audio experience." +
               "Optional technology package gives the car a head-up display for enhanced visibility, advanced parking assistance with a surround-view camera, and BMW's Live Cockpit Professional for an advanced digital instrument cluster.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 89.99M,
                    PricePerWeek = 549.99M,
                    ThumbnailImageId = 136
                });


                dbContext.Cars.Add( new Car()
                {
                    Id = 500,
                    CarMakeId = 11,
                    Model = "A4 Allroad",
                    Type = CarType.Estate,
                    Fuel = FuelType.Diesel,
                    ColorId = 4,
                    Horsepower = 286,
                    EngineCapacity = 2967,
                    Seats = 5,
                    Doors = 5,
                    Description = "The A4 Allroad 2022 is a versatile and adventurous luxury wagon that blends sophistication with off-road capabilities. In its base model, the A4 Allroad comes equipped with Audi's renowned quattro all-wheel-drive system, providing enhanced traction and stability in various driving conditions. " +
                    "The interior features premium materials and the latest Audi MMI infotainment system with a user-friendly 10.1-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
                    "Safety is a top priority, as the A4 Allroad 2022 comes with standard driver-assistance technologies, including automatic emergency braking, lane departure warning, and adaptive cruise control, ensuring a safe and confident driving experience.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 109.99M,
                    PricePerWeek = 689.99M,
                    ThumbnailImageId = 145
                });

                var carService = new CarService(dbContext);

                var queryModel = new AllCarsQueryModel
                {
                    CarSorting = Web.ViewModels.Car.Enums.CarSorting.Relevance,
                    CarType = CarType.Estate,
                    FuelType = FuelType.Diesel,
                    Drivetrain = Drivetrain.AWD,
                    Transmission = Transmission.Automatic,
                    MinimumPrice = Web.ViewModels.Car.Enums.MinimumPrice.From50,
                    MaximumPrice = Web.ViewModels.Car.Enums.MaximumPrice.To200,
                    MinHorsepower = 100,
                    MaxHorsepower = 500,
                    CarMake = "Audi",
                    Color = "Blue"
                };

                var result = await carService.AllAsync(queryModel);

                Assert.NotNull(result);
                Assert.That(result.Cars.Count, Is.EqualTo(0));
            }
        }

        [Test]
        public async Task AllArchivedAsync_ShouldReturnExpectedResult()
        {
            var dbContextOptions = new DbContextOptionsBuilder<RoadMateDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var dbContext = new RoadMateDbContext(dbContextOptions))
            {
                dbContext.Cars.Add(new Car()
                {
                    Id = 499,
                    CarMakeId = 10,
                    Model = "120d",
                    Type = CarType.Hatchback,
                    Fuel = FuelType.Diesel,
                    ColorId = 3,
                    Horsepower = 190,
                    EngineCapacity = 1995,
                    Seats = 5,
                    Doors = 5,
                    Description = "The BMW 120d F40 is a sporty and dynamic compact luxury car that exudes performance and sophistication. In its base model, the BMW 120d comes equipped with a powerful 2.0-liter TwinPower Turbo diesel engine, providing impressive acceleration and fuel efficiency. " +
               "The interior features premium materials and the latest BMW iDrive infotainment system with an intuitive 8.8-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
               "BMW 120d is equipped with luxurious leather upholstery, a panoramic sunroof for an airy cabin ambiance, and a Harman Kardon premium sound system for an immersive audio experience." +
               "Optional technology package gives the car a head-up display for enhanced visibility, advanced parking assistance with a surround-view camera, and BMW's Live Cockpit Professional for an advanced digital instrument cluster.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 89.99M,
                    PricePerWeek = 549.99M,
                    ThumbnailImageId = 136
                });

                dbContext.Cars.Add(new Car()
                {
                    Id = 500,
                    CarMakeId = 11,
                    Model = "A4 Allroad",
                    Type = CarType.Estate,
                    Fuel = FuelType.Diesel,
                    ColorId = 4,
                    Horsepower = 286,
                    EngineCapacity = 2967,
                    Seats = 5,
                    Doors = 5,
                    Description = "The A4 Allroad 2022 is a versatile and adventurous luxury wagon that blends sophistication with off-road capabilities. In its base model, the A4 Allroad comes equipped with Audi's renowned quattro all-wheel-drive system, providing enhanced traction and stability in various driving conditions. " +
                    "The interior features premium materials and the latest Audi MMI infotainment system with a user-friendly 10.1-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
                    "Safety is a top priority, as the A4 Allroad 2022 comes with standard driver-assistance technologies, including automatic emergency braking, lane departure warning, and adaptive cruise control, ensuring a safe and confident driving experience.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 109.99M,
                    PricePerWeek = 689.99M,
                    ThumbnailImageId = 145,
                    IsDeleted = true
                }) ;

                await dbContext.SaveChangesAsync();

                var carService = new CarService(dbContext);

                var queryModel = new ArchivedCarsQueryModel
                {
                    CarSorting = Web.ViewModels.Car.Enums.CarSorting.PriceDescending,
                    Drivetrain = Drivetrain.AWD,
                    Transmission = Transmission.Automatic,
                    FuelType = FuelType.Diesel,
                    CarType = CarType.Estate,
                    CarMake = "Audi",
                    
                };

                var result = await carService.AllArchivedAsync(queryModel);

                Assert.NotNull(result);
            }
        }

        [Test]
        public async Task AllRentalCarsAsync_ShouldReturnExpectedResult()
        {
            var dbContextOptions = new DbContextOptionsBuilder<RoadMateDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var dbContext = new RoadMateDbContext(dbContextOptions))
            {
                dbContext.Cars.Add(new Car()
                {
                    Id = 499,
                    CarMakeId = 10,
                    Model = "120d",
                    Type = CarType.Hatchback,
                    Fuel = FuelType.Diesel,
                    ColorId = 3,
                    Horsepower = 190,
                    EngineCapacity = 1995,
                    Seats = 5,
                    Doors = 5,
                    Description = "The BMW 120d F40 is a sporty and dynamic compact luxury car that exudes performance and sophistication. In its base model, the BMW 120d comes equipped with a powerful 2.0-liter TwinPower Turbo diesel engine, providing impressive acceleration and fuel efficiency. " +
               "The interior features premium materials and the latest BMW iDrive infotainment system with an intuitive 8.8-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
               "BMW 120d is equipped with luxurious leather upholstery, a panoramic sunroof for an airy cabin ambiance, and a Harman Kardon premium sound system for an immersive audio experience." +
               "Optional technology package gives the car a head-up display for enhanced visibility, advanced parking assistance with a surround-view camera, and BMW's Live Cockpit Professional for an advanced digital instrument cluster.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 89.99M,
                    PricePerWeek = 549.99M,
                    ThumbnailImageId = 136
                });

                dbContext.Cars.Add(new Car()
                {
                    Id = 500,
                    CarMakeId = 11,
                    Model = "A4 Allroad",
                    Type = CarType.Estate,
                    Fuel = FuelType.Diesel,
                    ColorId = 4,
                    Horsepower = 286,
                    EngineCapacity = 2967,
                    Seats = 5,
                    Doors = 5,
                    Description = "The A4 Allroad 2022 is a versatile and adventurous luxury wagon that blends sophistication with off-road capabilities. In its base model, the A4 Allroad comes equipped with Audi's renowned quattro all-wheel-drive system, providing enhanced traction and stability in various driving conditions. " +
                    "The interior features premium materials and the latest Audi MMI infotainment system with a user-friendly 10.1-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
                    "Safety is a top priority, as the A4 Allroad 2022 comes with standard driver-assistance technologies, including automatic emergency braking, lane departure warning, and adaptive cruise control, ensuring a safe and confident driving experience.",
                    Transmission = Transmission.Automatic,
                    Drivetrain = Drivetrain.AWD,
                    PricePerDay = 109.99M,
                    PricePerWeek = 689.99M,
                    ThumbnailImageId = 145,
                    IsDeleted = true
                });

                dbContext.Rentals.Add(new Rental { CarId = 499, StartDate = DateTime.Now.AddDays(-5), EndDate = DateTime.Now.AddDays(-3) });
                dbContext.Rentals.Add(new Rental { CarId = 500, StartDate = DateTime.Now.AddDays(-2), EndDate = DateTime.Now.AddDays(2) });

                await dbContext.SaveChangesAsync();

                var carService = new CarService(dbContext);

                var queryModel = new RentalCarsQueryModel
                {
                    CarSorting = Web.ViewModels.Car.Enums.CarSorting.PriceDescending,
                    CarMake = "Audi",
                    FuelType = FuelType.Diesel,
                    Transmission = Transmission.Automatic,
                    EndDate = DateTime.Now.AddDays(2),
                    StartDate = DateTime.Now.AddDays(-2),
                    MinimumPrice = Web.ViewModels.Car.Enums.MinimumPrice.From25,
                    MaximumPrice = Web.ViewModels.Car.Enums.MaximumPrice.Any
                };

                var result = await carService.AllRentalCarsAsync(queryModel);

                Assert.NotNull(result);
                Assert.AreEqual(0, result.Cars.Count());
            }
        }
    }
}
