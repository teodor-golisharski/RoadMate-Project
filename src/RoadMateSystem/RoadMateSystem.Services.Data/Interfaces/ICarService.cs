﻿namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Web.ViewModels.Review;

    public interface ICarService
    {
        Task<ImagesViewModel> PreviewCarImagesAsync();

        Task<CarDetailViewModel> GetCarDetailAsync(int id, ICollection<ReviewViewModel> reviews, ICollection<CarImageViewModel> images);
        Task<IEnumerable<AllCarsViewModel>> GetAllCarsAsync();
    }
}