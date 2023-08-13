namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;

    public class CarMakeService : ICarMakeService
    {
        private readonly RoadMateDbContext dbContext;

        public CarMakeService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
