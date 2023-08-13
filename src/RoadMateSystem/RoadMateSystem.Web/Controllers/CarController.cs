namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Web.ViewModels.Review;

    [Authorize]
    public class CarController : BaseController
    {
        private readonly ICarService carService;
        private readonly IReviewService reviewService;
        private readonly ICarImageService carImageService;

        public CarController(ICarService carService, IReviewService reviewService, ICarImageService carImageService)
        {
            this.carService = carService;
            this.reviewService = reviewService;
            this.carImageService = carImageService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllCarsViewModel> model = await carService.GetAllCarsAsync();

            return View(model);
        }

        public async Task<IActionResult> Edit()
        {
            return View();
        }

        public async Task<IActionResult> Add()
        {
            return View();
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            ICollection<ReviewViewModel> reviews = await reviewService.GetReviewsByCarIdAsync(id);
            ICollection<CarImageViewModel> images = await carImageService.GetImagesByCarIdAsync(id);

            CarDetailViewModel model = await carService.GetCarDetailAsync(id, reviews, images);

            return View(model);
        }
    }
}
