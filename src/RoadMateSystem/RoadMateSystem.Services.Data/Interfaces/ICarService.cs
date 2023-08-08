namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Home;

    public interface ICarService
    {
        Task<ImagesViewModel> PreviewCarImagesAsync();
    }
}
