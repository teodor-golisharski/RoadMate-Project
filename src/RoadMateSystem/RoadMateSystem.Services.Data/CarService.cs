namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Hosting;

    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Home;

    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CarService : ICarService
    {
        private readonly IHostEnvironment hostEnvironment;
        private readonly RoadMateDbContext dbContext;

        public CarService(RoadMateDbContext dbContext, IHostEnvironment hostEnvironment)
        {
            this.dbContext = dbContext;
            this.hostEnvironment = hostEnvironment;
        }

        public async Task<ImagesViewModel> PreviewCarImagesAsync()
        {
            ImagesViewModel queue = new ImagesViewModel();

            List<ImageViewModel> list = new List<ImageViewModel>();
            
            list = await dbContext
                .Cars
                .Select(x => new ImageViewModel
                {
                    Id = x.ThumbnailImage!.Id,
                    FileUrl = $"CarImages\\{string.Concat(x.CarMake.Make, x.Model)}\\{string.Concat(x.ThumbnailImage!.FileName, x.ThumbnailImage.FileExtension)}"
                })
                .ToListAsync();

            foreach (var item in list)
            {
                queue.ImageUrls.Enqueue(item);
            }

            return queue;
        }
    }
}
