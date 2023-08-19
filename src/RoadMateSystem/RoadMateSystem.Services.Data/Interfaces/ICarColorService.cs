namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.CarColor;

    public interface ICarColorService
    {
        Task AddAsync(ColorViewModel model);
        Task DeleteAsync(int id);
        Task<bool> DoesCarColorExistAsync(int id);
        Task EditAsync(int id, ColorViewModel viewModel);
        Task<IEnumerable<string>> GetAllCarColorsAsync();
        Task<IEnumerable<ColorViewModel>> GetAllColorsAsync();
        Task<ColorViewModel> GetViewModelByIdAsync(int id);
        Task RecoverAsync(int id);
    }
}