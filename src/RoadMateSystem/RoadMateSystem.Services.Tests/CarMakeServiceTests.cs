namespace RoadMateSystem.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using NUnit.Framework;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.CarMake;
    using static SeedDatabase;

    public class CarMakeServiceTests
    {
        private DbContextOptions<RoadMateDbContext> dbOptions;
        private RoadMateDbContext dbContext;

        private ICarMakeService carMakeService;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            this.dbOptions = new DbContextOptionsBuilder<RoadMateDbContext>()
                .UseInMemoryDatabase("CarRentingInMemory" + Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new RoadMateDbContext(this.dbOptions, false);

            this.dbContext.Database.EnsureCreated();
            Seed(this.dbContext);

            this.carMakeService = new CarMakeService(this.dbContext);
        }


        [Test]
        public async Task DoesCarMakeExistAsyncShouldReturnTrueIfExists()
        {
            int existCarMakeId = Make.Id;

            bool result = await this.carMakeService.DoesCarMakeExistAsync(existCarMakeId);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task DoesCarMakeExistAsyncShouldReturnFalseIfDoesNotExist()
        {
            int existCarMakeId = 999;

            bool result = await this.carMakeService.DoesCarMakeExistAsync(existCarMakeId);

            Assert.That(result, Is.False);
        }

        [Test]
        public async Task AddAsync_ShouldAddNewCarMake()
        {
            // Arrange
            using (var dbContext = new RoadMateDbContext(this.dbOptions, false))
            {
                var carMakeService = new CarMakeService(dbContext);
                var newCarMakeViewModel = new CarMakeViewModel { Make = "NewMake" };

                // Act
                await carMakeService.AddAsync(newCarMakeViewModel);

                // Assert
                var addedCarMake = await dbContext.CarMakes.FirstOrDefaultAsync(cm => cm.Make == "NewMake");
                Assert.NotNull(addedCarMake);
            }
        }

        [Test]
        public async Task RecoverAsyncShoulReturn()
        {
            CarMake make = new CarMake()
            {
                Id = 299,
                Make = "Make",
                IsDeleted = true,
            };
            await dbContext.CarMakes.AddAsync(make);

            await this.carMakeService.RecoverAsync(299);

            Assert.That(make.IsDeleted, Is.False);
        }

        [Test]
        public async Task DeleteAsyncShoulReturn()
        {
            CarMake make = new CarMake()
            {
                Id = 300,
                Make = "Make",
                IsDeleted = false,
            };
            await dbContext.CarMakes.AddAsync(make);

            await this.carMakeService.DeleteAsync(300);

            Assert.That(make.IsDeleted, Is.True);
        }

        [Test]
        public async Task TestAddAsync()
        {
            using (var dbContext = new RoadMateDbContext(this.dbOptions, false))
            {
                var carMakeService = new CarMakeService(dbContext);
                var newCarMakeViewModel = new CarMakeViewModel { Make = "NewMake" };

                await carMakeService.AddAsync(newCarMakeViewModel);

                var addedCarMake = dbContext.CarMakes.FirstOrDefault(cm => cm.Make == "NewMake");
                Assert.NotNull(addedCarMake);
            }
        }

        [Test]
        public async Task GetAllMakesAsync_ShouldReturnListOfCarMakeViewModels()
        {
            using (var dbContext = new RoadMateDbContext(this.dbOptions, false))
            {
                var carMakeService = new CarMakeService(dbContext);
                var result1 = await carMakeService.GetAllMakesAsync();
                var carMakesData = new List<CarMake>
                {
                    new CarMake { Id = 301, Make = "Make1", IsDeleted = false },
                    new CarMake { Id = 302, Make = "Make2", IsDeleted = true }
                };
                dbContext.CarMakes.AddRange(carMakesData);
                dbContext.SaveChanges();


                var result = await carMakeService.GetAllMakesAsync();

                Assert.NotNull(result);
                Assert.AreEqual(result1.Count() + 2, result.Count());

                var carMakeViewModel1 = result.FirstOrDefault(cm => cm.Id == 301);
                Assert.NotNull(carMakeViewModel1);
                Assert.AreEqual("Make1", carMakeViewModel1.Make);
                Assert.False(carMakeViewModel1.IsDeleted);

                var carMakeViewModel2 = result.FirstOrDefault(cm => cm.Id == 302);
                Assert.NotNull(carMakeViewModel2);
                Assert.AreEqual("Make2", carMakeViewModel2.Make);
                Assert.True(carMakeViewModel2.IsDeleted);
            }
        }

        [Test]
        public async Task EditAsync_ShouldUpdateCarMakeIfFound()
        {
            var dbContextOptions = new DbContextOptionsBuilder<RoadMateDbContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            using (var dbContext = new RoadMateDbContext(dbContextOptions))
            {
                var initialMake = "Initial Make";
                dbContext.CarMakes.Add(new CarMake { Id = 29, Make = initialMake });
                await dbContext.SaveChangesAsync();

                var carMakeService = new CarMakeService(dbContext);

                var newMake = "New Make";
                var carMakeViewModel = new CarMakeViewModel { Make = newMake };

                await carMakeService.EditAsync(29, carMakeViewModel);

                var updatedCarMake = await dbContext.CarMakes.FindAsync(29);
                Assert.NotNull(updatedCarMake);
                Assert.AreEqual(newMake, updatedCarMake.Make);

            }
        }
    }
}