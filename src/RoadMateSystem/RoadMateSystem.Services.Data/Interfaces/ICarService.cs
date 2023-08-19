namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Services.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.CarMake;
    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Web.ViewModels.Review;


    public interface ICarService
    {
        Task<ImagesViewModel> PreviewCarImagesAsync();
        Task<CarDetailViewModel> GetCarDetailAsync(int id, ICollection<ReviewViewModel> reviews, ICollection<CarImageViewModel> images);
        Task<ReviewCarViewModel> GetReviewCarViewModelAsync(int id);
        Task<AllCarsFilteredAndPagedServiceModel> AllAsync(AllCarsQueryModel queryModel);
        Task<AllCarsFilteredAndPagedServiceModel> AllArchivedAsync(ArchivedCarsQueryModel queryModel);
        Task<AllCarsFilteredAndPagedServiceModel> AllRentalCarsAsync(RentalCarsQueryModel queryModel);
        Task<bool> DoesCarExistAsync(int id);
        Task<bool> DoesArchivedCarExistAsync(int id);
        Task<EditCarViewModel> GetCarForEditAsync(int id);
        Task EditCarAsync(int id, EditCarViewModel model);
        Task DeleteAsync(int id);
        Task RecoverAsync(int id);
    }
}
