namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.CarImage;

    public interface ICarImageService
    {
        Task<ICollection<CarImageViewModel>> GetImagesByCarIdAsync(int id);
    }
}
