namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.CarMake;

    public interface ICarMakeService
    {
        Task<IEnumerable<string>> GetAllCarMakesAsync();
        Task<IEnumerable<CarMakeViewModel>> GetAllMakesAsync();
        Task<CarMakeViewModel> GetViewModelByIdAsync(int id);
        Task EditAsync(int id, CarMakeViewModel model);
        Task DeleteAsync(int id);
        Task RecoverAsync(int id);
        Task<bool> DoesCarMakeExistAsync(int id);
        Task AddAsync(CarMakeViewModel model);
        Task<string> GetMakeByIdAsync(int id);
    }
}
