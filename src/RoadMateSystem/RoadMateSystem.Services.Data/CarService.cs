namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Hosting;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Web.ViewModels.Review;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class CarService : ICarService
    {
        private readonly RoadMateDbContext dbContext;

        public CarService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
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

        public async Task<CarDetailViewModel> GetCarDetailAsync(int id)
        {
            ICollection<CarImageViewModel> images = await dbContext
                .CarImages
                .Select(ci => new CarImageViewModel
                {
                    Id = ci.Id,
                    FileUrl = $"..\\..\\CarImages\\{string.Concat(ci.Car.CarMake.Make, ci.Car.Model)}\\{string.Concat(ci.FileName, ci.FileExtension)}",
                    CarId = ci.Car.Id
                })
                .Where(x => x.CarId == id) 
                .ToListAsync();

            ICollection<ReviewViewModel> reviews = await dbContext
                .Reviews
                .Select(r => new ReviewViewModel 
                { 
                    ReviewId = r.ReviewId.ToString(),
                    CarId = r.Car.Id,
                    UserName = string.Concat(r.User.FirstName, " ", r.User.LastName),
                    Rating = r.Rating,
                    Comment = r.Comment,
                    DatePosted = r.DatePosted
                })
                .Where(x => x.CarId == id)
                .ToListAsync();

            CarDetailViewModel viewModel = await dbContext
                .Cars
                .Select(c => new CarDetailViewModel
                {
                    Id = c.Id,
                    CarMake = c.CarMake.Make,
                    Model = c.Model,
                    Type = c.Type,
                    Fuel = c.Fuel,
                    Color = c.Color.Name,
                    Horsepower = c.Horsepower,
                    EngineCapacity = c.EngineCapacity,
                    Seats = c.Seats,    
                    Doors = c.Doors,
                    Description = c.Description,
                    Transmission = c.Transmission,
                    Drivetrain = c.Drivetrain,
                    PricePerDay = c.PricePerDay,
                    PricePerWeek = c.PricePerWeek,
                    ThumbnailUrl = $"..\\..\\CarImages\\{string.Concat(c.CarMake.Make, c.Model)}\\{string.Concat(c.ThumbnailImage!.FileName, c.ThumbnailImage.FileExtension)}",
                    Images = images,
                    Reviews = reviews

                })
                .FirstAsync(x => x.Id == id);

            return viewModel;

        }

        public async Task<IEnumerable<AllCarsViewModel>> GetAllCarsAsync()
        {
            IEnumerable<AllCarsViewModel> allCarsViewModels = new List<AllCarsViewModel>();

            allCarsViewModels = await dbContext
                .Cars
                .Select(c => new AllCarsViewModel
                {
                    Id = c.Id,
                    MakeModel = string.Concat(c.CarMake.Make, " ", c.Model),
                    CarType = c.Type,
                    Fuel = c.Fuel,
                    Horsepower = c.Horsepower,
                    Transmission = c.Transmission,
                    PricePerWeek = c.PricePerWeek,
                    PricePerDay = c.PricePerDay,
                    ThumbnailImageUrl = $"..\\..\\CarImages\\{string.Concat(c.CarMake.Make, c.Model)}\\{string.Concat(c.ThumbnailImage!.FileName, c.ThumbnailImage.FileExtension)}"
                })
                .ToListAsync();

            return allCarsViewModels;
        }
    }
}
