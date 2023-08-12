namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Web.ViewModels.Rental;

    public interface IRentalService
    {
        Task RentCarAsync(RentalViewModel model, string userId, int id);

        Task<RentalViewModel> GetRentCarAsync(int carId);

        Task<RentalViewModel> GetCurrentRentCarAsync(int id, RentalViewModel currentModel);

        Task<IEnumerable<AllRentalsByCarIdViewModel>> GetAllRentalsByCarIdAsync(int id);

        Task<bool> IsCarAvailableAsync(IEnumerable<AllRentalsByCarIdViewModel> carRentals, RentalViewModel model);
    }
}
