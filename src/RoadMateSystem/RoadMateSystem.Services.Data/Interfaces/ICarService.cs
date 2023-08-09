namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Home;

    public interface ICarService
    {
        Task<ImagesViewModel> PreviewCarImagesAsync();

        Task<CarDetailViewModel> GetCarDetailAsync(int id);

        Task<IEnumerable<AllCarsViewModel>> GetAllCarsAsync();
    }
}
