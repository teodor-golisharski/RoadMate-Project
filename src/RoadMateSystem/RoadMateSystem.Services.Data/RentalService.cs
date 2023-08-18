namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Car.Enums;
    using RoadMateSystem.Web.ViewModels.Rental;
    using RoadMateSystem.Web.ViewModels.Rental.Enums;
    using System.ComponentModel;

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
            TimeSpan rentalDuration = model.EndDate.Date - model.StartDate.Date;
            double totalCost;

            if (rentalDuration.TotalDays + 1 >= 7)
            {
                totalCost = (rentalDuration.TotalDays + 1) / 7 * (double)model.Car!.PricePerWeek!;
            }
            else
            {
                totalCost = (rentalDuration.TotalDays + 1) * (double)model.Car!.PricePerDay;
            }

            Rental @rent = new Rental()
            {
                CarId = id,
                UserId = Guid.Parse(userId),
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                IsPaid = false,
                TotalCost = (decimal)totalCost,
                CreatedOn = DateTime.Now
            };

            await dbContext.Rentals.AddAsync(@rent);
            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<AllRentalsByCarIdViewModel>> GetAllRentalsByCarIdAsync(int id)
        {
            IEnumerable<AllRentalsByCarIdViewModel> viewModel = 
                await dbContext
                .Rentals
                .Select(r => new AllRentalsByCarIdViewModel 
                { 
                    RentalId = r.RentalId, 
                    CarId = r.CarId,
                    StartDate = r.StartDate,
                    EndDate = r.EndDate,
                })
                .Where(r => r.CarId == id)
                .ToListAsync();

            return viewModel;
        }

        public async Task<bool> IsCarAvailableAsync(IEnumerable<AllRentalsByCarIdViewModel> carRentals, RentalViewModel model)
        {
            await Task.Yield();

            bool result = carRentals
                .Any(r => (model.StartDate >= r.StartDate && model.StartDate <= r.EndDate) || (model.EndDate >= r.StartDate && model.EndDate <= r.EndDate));

            return result;
        }

        public async Task<AllRentalsFilteredAndPagedServiceModel> GetAllRentalsOfUser(UserRentalsQueryModel queryModel, string userId)
        {
            IQueryable<Rental> rentalsQuery = dbContext
                .Rentals
                .AsQueryable();

            rentalsQuery = rentalsQuery
                .Where(r => r.UserId == Guid.Parse(userId));

            rentalsQuery = queryModel.RentalsSorting switch
            {
                RentalsSorting.Relevance => rentalsQuery,
                RentalsSorting.Newest => rentalsQuery
                    .OrderByDescending(r => r.CreatedOn),
                RentalsSorting.Oldest => rentalsQuery
                    .OrderBy(r => r.CreatedOn),
                RentalsSorting.TotalCostAscending => rentalsQuery
                    .OrderBy(r => r.TotalCost),
                RentalsSorting.TotalCostDescending => rentalsQuery
                    .OrderByDescending(r => r.TotalCost),
                _ => rentalsQuery
            };
            
            IEnumerable<UserRentalsViewModel> rentals = await rentalsQuery
                .Skip((queryModel.CurrentPage - 1) * queryModel.RentalsPerPage)
                .Take(queryModel.RentalsPerPage)
                .Select(r => new UserRentalsViewModel
                {
                    RentalId = r.RentalId,
                    CarId = r.CarId, 
                    MakeModel = string.Concat(r.Car.CarMake.Make, " ", r.Car.Model),
                    ThumbnailImageUrl = $"..\\..\\CarImages\\{string.Concat(r.Car.CarMake.Make, r.Car.Model)}\\{string.Concat(r.Car.ThumbnailImage!.FileName, r.Car.ThumbnailImage.FileExtension)}",
                    StartDate = r.StartDate,
                    EndDate = r.EndDate,
                    UserId = r.UserId.ToString(),
                    TotalCost = r.TotalCost,
                    isPaid = r.IsPaid,
                    CreatedOn = r.CreatedOn,
                })
                .ToArrayAsync();

            int rentalsCount = rentalsQuery.Count();

            return new AllRentalsFilteredAndPagedServiceModel()
            {
                TotalRentals = rentalsCount,
                Rentals = rentals
            };
        }
    }
}
