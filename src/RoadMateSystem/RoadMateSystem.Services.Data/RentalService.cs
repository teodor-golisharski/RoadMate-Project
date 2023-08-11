namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Rental;

    public class RentalService : IRentalService
    {
        private readonly RoadMateDbContext dbContext;

        public RentalService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<RentalViewModel> GetCurrentRentCarAsync(int id, RentalViewModel currentModel)
        {
            RentCarViewModel model = await dbContext
                .Cars
                .Select(c => new RentCarViewModel
                {
                    Id = c.Id,
                    MakeModel = string.Concat(c.CarMake.Make, " ", c.Model),
                    CarType = c.Type,
                    Fuel = c.Fuel,
                    Horsepower = c.Horsepower,
                    Description = c.Description,
                    Transmission = c.Transmission,
                    PricePerWeek = c.PricePerWeek,
                    PricePerDay = c.PricePerDay,
                    ThumbnailImageUrl = $"..\\..\\CarImages\\{string.Concat(c.CarMake.Make, c.Model)}\\{string.Concat(c.ThumbnailImage!.FileName, c.ThumbnailImage.FileExtension)}"
                })
                .FirstAsync(c => c.Id == id);

            currentModel = new RentalViewModel()
            {
                CarId = id,
                Car = model,
                StartDate = currentModel.StartDate,
                EndDate = currentModel.EndDate
            };

            return currentModel;
        }

        // Rent HttpGet
        public async Task<RentalViewModel> GetRentCarAsync(int id)
        {
            RentCarViewModel model = await dbContext
                .Cars
                .Select(c => new RentCarViewModel
                {
                    Id = c.Id,
                    MakeModel = string.Concat(c.CarMake.Make, " ", c.Model),
                    CarType = c.Type,
                    Fuel = c.Fuel,
                    Horsepower = c.Horsepower,
                    Description = c.Description,
                    Transmission = c.Transmission,
                    PricePerWeek = c.PricePerWeek,
                    PricePerDay = c.PricePerDay,
                    ThumbnailImageUrl = $"..\\..\\CarImages\\{string.Concat(c.CarMake.Make, c.Model)}\\{string.Concat(c.ThumbnailImage!.FileName, c.ThumbnailImage.FileExtension)}"
                })
                .FirstAsync(c => c.Id == id);

            RentalViewModel viewModel = new RentalViewModel()
            {
                CarId = id,
                Car = model
            };

            return viewModel;
        }

        // Rent HttpPost
        public async Task RentCarAsync(RentalViewModel model, string userId, int id)
        {
            Rental @rent = new Rental()
            {
                RentalId = Guid.NewGuid(),
                CarId = id,
                UserId = Guid.Parse(userId),
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                TotalCost = model.TotalCost,
                IsPaid = false,
                CreatedOn = DateTime.Now
            };

            await dbContext.Rentals.AddAsync(@rent);
            await dbContext.SaveChangesAsync();
        }
    }
}
