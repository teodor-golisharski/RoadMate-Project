﻿namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.ViewModels.Rental;

    public interface IRentalService
    {
        Task RentCarAsync(RentalViewModel model, string userId, int id);

        Task<RentalViewModel> GetRentCarAsync(int carId);

        Task<RentalViewModel> GetCurrentRentCarAsync(int id, RentalViewModel currentModel);

        Task<IEnumerable<AllRentalsByCarIdViewModel>> GetAllRentalsByCarIdAsync(int id);

        Task<bool> IsCarAvailableAsync(IEnumerable<AllRentalsByCarIdViewModel> carRentals, RentalViewModel model);

        Task<AllRentalsFilteredAndPagedServiceModel> GetAllRentalsOfUser(UserRentalsQueryModel queryModel, string userId);

        Task<AllRentalsFilteredAndPagedServiceModel> GetAllRentalsAsync(UserRentalsQueryModel queryModel);

        Task UserPaidAsync(string rentalId);
        Task<bool> DoesRentalExistAsync(string rentalId);
        Task RecoverAsync(string rentalId);
        Task DeleteAsync(string rentalId);
    }
}
