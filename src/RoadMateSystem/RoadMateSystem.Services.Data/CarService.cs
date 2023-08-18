namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Car;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Car.Enums;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.CarMake;
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
                    FileUrl = $"..\\CarImages\\{string.Concat(x.CarMake.Make, x.Model)}\\{string.Concat(x.ThumbnailImage!.FileName, x.ThumbnailImage.FileExtension)}"
                })
                .ToListAsync();

            foreach (var item in list)
            {
                queue.ImageUrls.Enqueue(item);
            }

            return queue;
        }

        public async Task<CarDetailViewModel> GetCarDetailAsync(int id, ICollection<ReviewViewModel> reviews, ICollection<CarImageViewModel> images)
        {
            CarMakeModelViewModel carMakeModel = await dbContext
                .Cars
                .Select(cmm => new CarMakeModelViewModel
                {
                    Id = cmm.Id,
                    Make = cmm.CarMake.Make,
                    Model = cmm.Model
                })
                .FirstAsync(cmm => cmm.Id == id);

            string makeModel = string.Concat(carMakeModel.Make, carMakeModel.Model);

            CarColorViewModel colorModel = await dbContext
                .Cars
                .Select(cm => new CarColorViewModel
                {
                    Id = cm.Color.Id,
                    Name = cm.Color.Name,
                    Hex = cm.Color.Hex,
                    CarId = cm.Id
                })
                .FirstAsync(cm => cm.CarId == id);



            CarDetailViewModel viewModel = await dbContext
                .Cars
                .Select(c => new CarDetailViewModel
                {
                    Id = c.Id,
                    CarMake = c.CarMake.Make,
                    Model = c.Model,
                    Type = c.Type,
                    Fuel = c.Fuel,
                    Color = colorModel,
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

        public async Task<ReviewCarViewModel> GetReviewCarViewModelAsync(int id)
        {
            ReviewCarViewModel viewModel = await dbContext
                .Cars
                .Select(c => new ReviewCarViewModel
                {
                    Id = c.Id,
                    MakeModel = string.Concat(c.CarMake.Make, " ", c.Model),
                    ThumbnailImageUrl = $"..\\..\\CarImages\\{string.Concat(c.CarMake.Make, c.Model)}\\{string.Concat(c.ThumbnailImage!.FileName, c.ThumbnailImage.FileExtension)}",
                    CarType = c.Type,
                    Fuel = c.Fuel,
                    Horsepower = c.Horsepower,
                    Color = c.Color.Name,
                    Seats = c.Seats
                })
                .FirstAsync(c => c.Id == id);

            return viewModel;
        }

        public async Task<AllCarsFilteredAndPagedServiceModel> AllAsync(AllCarsQueryModel queryModel)
        {
            IQueryable<Car> carsQuery = dbContext
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.Color))
            {
                carsQuery = carsQuery
                    .Where(c => c.Color.Name == queryModel.Color);
            }

            if (!string.IsNullOrWhiteSpace(queryModel.CarMake))
            {
                carsQuery = carsQuery
                    .Where(c => c.CarMake.Make == queryModel.CarMake);
            }

            carsQuery = carsQuery.Where(c => c.Horsepower >= queryModel.MinHorsepower && c.Horsepower <= queryModel.MaxHorsepower);

            carsQuery = queryModel.Drivetrain switch
            {
                Drivetrain.AWD => carsQuery
                    .Where(c => c.Drivetrain == Drivetrain.AWD),
                Drivetrain.RWD => carsQuery
                    .Where(c => c.Drivetrain == Drivetrain.RWD),
                Drivetrain.FWD => carsQuery
                    .Where(c => c.Drivetrain == Drivetrain.FWD),
                _ => carsQuery
            };

            carsQuery = queryModel.Transmission switch
            {
                Transmission.Automatic => carsQuery
                    .Where(c => c.Transmission == Transmission.Automatic),
                Transmission.Manual => carsQuery
                    .Where(c => c.Transmission == Transmission.Manual),
                _ => carsQuery
            };

            carsQuery = queryModel.FuelType switch
            {
                FuelType.Gasoline => carsQuery
                    .Where(c => c.Fuel == FuelType.Gasoline),
                FuelType.Diesel => carsQuery
                    .Where(c => c.Fuel == FuelType.Diesel),
                FuelType.Hybrid => carsQuery
                    .Where(c => c.Fuel == FuelType.Hybrid),
                FuelType.LPG => carsQuery
                    .Where(c => c.Fuel == FuelType.LPG),
                FuelType.Electric => carsQuery
                    .Where(c => c.Fuel == FuelType.Electric),
                _ => carsQuery
            };

            carsQuery = queryModel.CarType switch
            {
                CarType.Saloon => carsQuery
                    .Where(c => c.Type == CarType.Saloon),
                CarType.SUV => carsQuery
                    .Where(c => c.Type == CarType.SUV),
                CarType.Hatchback => carsQuery
                    .Where(c => c.Type == CarType.Hatchback),
                CarType.Coupe => carsQuery
                    .Where(c => c.Type == CarType.Coupe),
                CarType.Pickup => carsQuery
                    .Where(c => c.Type == CarType.Pickup),
                CarType.Estate => carsQuery
                    .Where(c => c.Type == CarType.Estate),
                CarType.Convertible => carsQuery
                    .Where(c => c.Type == CarType.Convertible),
                CarType.Van => carsQuery
                    .Where(c => c.Type == CarType.Van),
                _ => carsQuery
            };

            carsQuery = queryModel.MinimumPrice switch
            {
                MinimumPrice.From25 => carsQuery
                    .Where(c => c.PricePerDay >= 25),
                MinimumPrice.From50 => carsQuery
                    .Where(c => c.PricePerDay >= 50),
                MinimumPrice.From75 => carsQuery
                    .Where(c => c.PricePerDay >= 75),
                MinimumPrice.From100 => carsQuery
                    .Where(c => c.PricePerDay >= 100),
                MinimumPrice.From150 => carsQuery
                    .Where(c => c.PricePerDay >= 150),
                MinimumPrice.From200 => carsQuery
                    .Where(c => c.PricePerDay >= 200),
                MinimumPrice.From250 => carsQuery
                    .Where(c => c.PricePerDay >= 250),
                MinimumPrice.From300 => carsQuery
                    .Where(c => c.PricePerDay >= 300),
                MinimumPrice.Any => carsQuery,
                _ => carsQuery
            };

            carsQuery = queryModel.MaximumPrice switch
            {
                MaximumPrice.To50 => carsQuery
                    .Where(c => c.PricePerDay <= 50),
                MaximumPrice.To75 => carsQuery
                    .Where(c => c.PricePerDay <= 75),
                MaximumPrice.To100 => carsQuery
                    .Where(c => c.PricePerDay <= 100),
                MaximumPrice.To150 => carsQuery
                    .Where(c => c.PricePerDay <= 150),
                MaximumPrice.To200 => carsQuery
                    .Where(c => c.PricePerDay <= 200),
                MaximumPrice.To250 => carsQuery
                    .Where(c => c.PricePerDay <= 250),
                MaximumPrice.To300 => carsQuery
                    .Where(c => c.PricePerDay <= 300),
                MaximumPrice.To400 => carsQuery
                    .Where(c => c.PricePerDay <= 400),
                MaximumPrice.Any => carsQuery,
                _ => carsQuery
            };

            carsQuery = queryModel.CarSorting switch
            {
                CarSorting.Relevance => carsQuery
                    .OrderBy(h => h.Id),
                CarSorting.PriceAscending => carsQuery
                    .OrderBy(h => h.PricePerDay)
                    .ThenBy(h => h.PricePerWeek),
                CarSorting.PriceDescending => carsQuery
                    .OrderByDescending(h => h.PricePerDay)
                    .ThenBy(h => h.PricePerWeek),
                CarSorting.HorsepowerAscending => carsQuery
                    .OrderBy(h => h.Horsepower),
                CarSorting.HorsepowerDescending => carsQuery
                    .OrderByDescending(h => h.Horsepower),
                _ => carsQuery.OrderBy(h => h.Id)
            };

            IEnumerable<AllCarsViewModel> allCars = await carsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.CarsPerPage)
                .Take(queryModel.CarsPerPage)
                .Select(c => new AllCarsViewModel()
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
                .ToArrayAsync();

            int totalCars = carsQuery.Count();

            return new AllCarsFilteredAndPagedServiceModel()
            {
                TotalCarsCount = totalCars,
                Cars = allCars,
            };

        }

        public async Task<AllCarsFilteredAndPagedServiceModel> AllRentalCarsAsync(RentalCarsQueryModel queryModel)
        {

            IQueryable<Car> carsQuery = dbContext
                .Cars
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(queryModel.CarMake))
            {
                carsQuery = carsQuery
                    .Where(c => c.CarMake.Make == queryModel.CarMake);
            }

            carsQuery = queryModel.Transmission switch
            {
                Transmission.Automatic => carsQuery
                    .Where(c => c.Transmission == Transmission.Automatic),
                Transmission.Manual => carsQuery
                    .Where(c => c.Transmission == Transmission.Manual),
                _ => carsQuery
            };

            carsQuery = queryModel.FuelType switch
            {
                FuelType.Gasoline => carsQuery
                    .Where(c => c.Fuel == FuelType.Gasoline),
                FuelType.Diesel => carsQuery
                    .Where(c => c.Fuel == FuelType.Diesel),
                FuelType.Hybrid => carsQuery
                    .Where(c => c.Fuel == FuelType.Hybrid),
                FuelType.LPG => carsQuery
                    .Where(c => c.Fuel == FuelType.LPG),
                FuelType.Electric => carsQuery
                    .Where(c => c.Fuel == FuelType.Electric),
                _ => carsQuery
            };


            carsQuery = queryModel.MinimumPrice switch
            {
                MinimumPrice.From25 => carsQuery
                    .Where(c => c.PricePerDay >= 25),
                MinimumPrice.From50 => carsQuery
                    .Where(c => c.PricePerDay >= 50),
                MinimumPrice.From75 => carsQuery
                    .Where(c => c.PricePerDay >= 75),
                MinimumPrice.From100 => carsQuery
                    .Where(c => c.PricePerDay >= 100),
                MinimumPrice.From150 => carsQuery
                    .Where(c => c.PricePerDay >= 150),
                MinimumPrice.From200 => carsQuery
                    .Where(c => c.PricePerDay >= 200),
                MinimumPrice.From250 => carsQuery
                    .Where(c => c.PricePerDay >= 250),
                MinimumPrice.From300 => carsQuery
                    .Where(c => c.PricePerDay >= 300),
                MinimumPrice.Any => carsQuery,
                _ => carsQuery
            };

            carsQuery = queryModel.MaximumPrice switch
            {
                MaximumPrice.To50 => carsQuery
                    .Where(c => c.PricePerDay <= 50),
                MaximumPrice.To75 => carsQuery
                    .Where(c => c.PricePerDay <= 75),
                MaximumPrice.To100 => carsQuery
                    .Where(c => c.PricePerDay <= 100),
                MaximumPrice.To150 => carsQuery
                    .Where(c => c.PricePerDay <= 150),
                MaximumPrice.To200 => carsQuery
                    .Where(c => c.PricePerDay <= 200),
                MaximumPrice.To250 => carsQuery
                    .Where(c => c.PricePerDay <= 250),
                MaximumPrice.To300 => carsQuery
                    .Where(c => c.PricePerDay <= 300),
                MaximumPrice.To400 => carsQuery
                    .Where(c => c.PricePerDay <= 400),
                MaximumPrice.Any => carsQuery,
                _ => carsQuery
            };

            carsQuery = queryModel.CarSorting switch
            {
                CarSorting.Relevance => carsQuery
                    .OrderBy(h => h.Id),
                CarSorting.PriceAscending => carsQuery
                    .OrderBy(h => h.PricePerDay)
                    .ThenBy(h => h.PricePerWeek),
                CarSorting.PriceDescending => carsQuery
                    .OrderByDescending(h => h.PricePerDay)
                    .ThenBy(h => h.PricePerWeek),
                CarSorting.HorsepowerAscending => carsQuery
                    .OrderBy(h => h.Horsepower),
                CarSorting.HorsepowerDescending => carsQuery
                    .OrderByDescending(h => h.Horsepower),
                _ => carsQuery.OrderBy(h => h.Id)
            };


            carsQuery = carsQuery
                .Where(c => !dbContext
                    .Rentals
                    .Any(r => r.CarId == c.Id && (
                        (queryModel.StartDate >= r.StartDate && queryModel.StartDate <= r.EndDate) ||
                        (queryModel.EndDate >= r.StartDate && queryModel.EndDate <= r.EndDate))));



            IEnumerable<AllCarsViewModel> allCars = await carsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.CarsPerPage)
                .Take(queryModel.CarsPerPage)
                .Select(c => new AllCarsViewModel()
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
                .ToArrayAsync();

            int totalCars = carsQuery.Count();

            return new AllCarsFilteredAndPagedServiceModel()
            {
                TotalCarsCount = totalCars,
                Cars = allCars,
            };
        }

        public async Task<bool> DoesCarExistAsync(int id) => await dbContext.Cars.AnyAsync(c => c.Id == id);
    }
}
