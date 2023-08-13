namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;

    public class CarImageService : ICarImageService
    {
        private readonly RoadMateDbContext dbContext;

        public CarImageService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<CarImageViewModel>> GetImagesByCarIdAsync(int id)
        {
            CarMakeModelViewModel makeModel = await dbContext
                .Cars
                .Select(x => new CarMakeModelViewModel
                {
                    Id = x.Id,
                    Make = x.CarMake.Make,
                    Model = x.Model,
                })
                .FirstAsync(x => id == x.Id);

            string carMakeModel = string.Concat(makeModel.Make, makeModel.Model);

            ICollection<CarImageViewModel> images = await dbContext
                    .CarImages
                    .Select(ci => new CarImageViewModel
                    {
                        Id = ci.Id,
                        FileUrl = $"..\\..\\CarImages\\{carMakeModel}\\{string.Concat(ci.FileName, ci.FileExtension)}",
                        CarId = ci.CarId
                    })
                    .Where(ci => ci.CarId == id)
                    .ToListAsync();

            return images;
        }
    }
}
