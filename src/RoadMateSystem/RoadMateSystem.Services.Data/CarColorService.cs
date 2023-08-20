namespace RoadMateSystem.Services.Data
{
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using RoadMateSystem.Web.ViewModels.CarMake;

    public class CarColorService : ICarColorService
    {
        private readonly RoadMateDbContext dbContext;

        public CarColorService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddAsync(ColorViewModel model)
        {
            CarColor carColor = new CarColor()
            {
                Name = model.Name,
                Hex = model.Hex,  
            };

            await dbContext.Colors.AddAsync(carColor);
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            CarColor? car = await dbContext.Colors.FindAsync(id);

            if (car != null && car.IsDeleted == false)
            {
                car.IsDeleted = true;
                await dbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> DoesCarColorExistAsync(int id) => await dbContext.Colors.AnyAsync(c => c.Id == id);

        public async Task EditAsync(int id, ColorViewModel viewModel)
        {
            CarColor? carColor = await dbContext.Colors.FindAsync(id);

            if (carColor != null)
            {
                carColor.Name = viewModel.Name;
                carColor.Hex = viewModel.Hex;
            }

            await dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<string>> GetAllCarColorsAsync()
        {
            IEnumerable<string> colors = await dbContext
                .Colors
                .Select(c => c.Name)
                .ToListAsync();

            return colors;
        }

        public async Task<IEnumerable<ColorViewModel>> GetAllColorsAsync()
        {
            IEnumerable<ColorViewModel> colorViewModels = await dbContext
                .Colors
                .Select(c => new ColorViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Hex = c.Hex,
                    IsDeleted = c.IsDeleted,
                })
                .ToListAsync();

            return colorViewModels;
        }

        public async Task<ColorViewModel> GetViewModelByIdAsync(int id)
        {
            ColorViewModel viewModel = await dbContext
                .Colors
                .Select(x => new ColorViewModel
                {
                    Id = x.Id,
                    Name = x.Name,
                    Hex = x.Hex,
                    IsDeleted = x.IsDeleted,
                })
                .FirstAsync(x => x.Id == id);

            return viewModel;
        }

        public async Task RecoverAsync(int id)
        {
            CarColor? car = await dbContext.Colors.FindAsync(id);

            if (car != null && car.IsDeleted == true)
            {
                car.IsDeleted = false;
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
