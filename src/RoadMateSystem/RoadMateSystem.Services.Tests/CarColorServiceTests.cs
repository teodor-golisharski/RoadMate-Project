namespace RoadMateSystem.Services.Tests
{
    using Microsoft.EntityFrameworkCore;
    using Moq;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using static RoadMateSystem.Data.Models.Car.CarColor;

    public class CarColorServiceTests
    {
        private DbContextOptions<RoadMateDbContext> dbOptions;
        private RoadMateDbContext dbContext;

        private ICarColorService service;

        //[Test]
        //public async Task AddAsync_ShouldAddColorToDatabase()
        //{
        //    service = new CarColorService(dbContext);
        //    var colorViewModel = new ColorViewModel
        //    {
        //        Name = "Red",
        //        Hex = "#FF0000"
        //    };

        //    await service.AddAsync(colorViewModel);
        //    await dbContext.SaveChangesAsync();

        //    var addedColor = dbContext.Colors.FirstOrDefault();

        //    Assert.NotNull(addedColor);
        //    Assert.AreEqual("Red", addedColor.Name);
        //    Assert.AreEqual("#FF0000", addedColor.Hex);
        //}


    }
}
