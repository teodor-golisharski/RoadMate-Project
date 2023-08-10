namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.Rental;

    public class RentalService : IRentalService
    {
        private readonly RoadMateDbContext dbContext;

        public RentalService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        // Rent HttpGet
        public async Task<RentalViewModel> GetRentCarAsync(int id)
        {
            RentalViewModel viewModel = new RentalViewModel()
            {
                CarId = id
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
                IsPaid = false
            };

            await dbContext.Rentals.AddAsync(@rent);
            await dbContext.SaveChangesAsync();
        }
    }
}
