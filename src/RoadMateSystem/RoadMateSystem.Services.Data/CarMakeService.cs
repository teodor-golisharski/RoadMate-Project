namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;

    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.CarMake;

    public class CarMakeService : ICarMakeService
    {
        private readonly RoadMateDbContext dbContext;

        public CarMakeService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<string>> GetAllCarMakesAsync()
        {
            IEnumerable<string> carMakes = await dbContext
                .CarMakes
                .Select(x => x.Make)
                .ToListAsync();

            return carMakes;
        }

        public async Task<IEnumerable<CarMakeViewModel>> GetAllMakesAsync()
        {
            IEnumerable<CarMakeViewModel> carMakeViewModels = await dbContext
                .CarMakes
                .Select(cm => new CarMakeViewModel
                {
                    Id = cm.Id,
                    Make = cm.Make,
                    IsDeleted = cm.IsDeleted,
                })
                .ToListAsync();

            return carMakeViewModels;
        }
        
        public async Task<CarMakeViewModel> GetViewModelByIdAsync(int id)
        {
            CarMakeViewModel viewModel = await dbContext
                .CarMakes
                .Select(x => new CarMakeViewModel
                { 
                    Id= x.Id, 
                    Make = x.Make,
                    IsDeleted = x.IsDeleted,
                })
                .FirstAsync(x => x.Id == id);

            return viewModel;
        }

        public async Task EditAsync(int id, CarMakeViewModel model)
        {
            CarMake? carMake = await dbContext.CarMakes.FindAsync(id);

            if (carMake != null)
            {
                carMake.Make = model.Make;
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            CarMake? car = await dbContext.CarMakes.FindAsync(id);

            if (car != null && car.IsDeleted == false)
            {
                car.IsDeleted = true;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task RecoverAsync(int id)
        {
            CarMake? car = await dbContext.CarMakes.FindAsync(id);

            if (car != null && car.IsDeleted == true)
            {
                car.IsDeleted = false;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> DoesCarMakeExistAsync(int id) => await dbContext.CarMakes.AnyAsync(x => x.Id == id);

        public async Task AddAsync(CarMakeViewModel model)
        {
            CarMake carMake = new CarMake()
            {
                Make = model.Make,
            };

            await dbContext.AddAsync(carMake);
            await dbContext.SaveChangesAsync();
        }
    }
}
