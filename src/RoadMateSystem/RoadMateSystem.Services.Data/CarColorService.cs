namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.CarColor;

    public class CarColorService : ICarColorService
    {
        private readonly RoadMateDbContext dbContext;

        public CarColorService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetAllCarColorsAsync()
        {
            IEnumerable<string> colors = await dbContext
                .Colors
                .Select(c => c.Name)
                .ToListAsync();

            return colors;
        }
    }
}
