﻿namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.Review;

    using static Common.NotificationMessagesConstants;
    using static Common.NotificationTextConstants;

    [Authorize()]
    public class CarController : BaseController
    {
        private readonly ICarService carService;
        private readonly IReviewService reviewService;
        private readonly ICarImageService carImageService;
        private readonly ICarMakeService carMakeService;
        private readonly ICarColorService carColorService;

        public CarController(ICarService carService, IReviewService reviewService, ICarImageService carImageService, ICarMakeService carMakeService, ICarColorService carColorService)
        {
            this.carService = carService;
            this.reviewService = reviewService;
            this.carImageService = carImageService;
            this.carMakeService = carMakeService;
            this.carColorService = carColorService;
        }

        public async Task<IActionResult> All([FromQuery] AllCarsQueryModel queryModel)
        {
            AllCarsFilteredAndPagedServiceModel serviceModel = await this.carService.AllAsync(queryModel);

            queryModel.Cars = serviceModel.Cars;
            queryModel.TotalCars = serviceModel.TotalCarsCount;
            queryModel.CarMakes = await carMakeService.GetAllCarMakesAsync();
            queryModel.Colors = await carColorService.GetAllCarColorsAsync();

            return View(queryModel);
        }

        public async Task<IActionResult> RentalCars([FromQuery] RentalCarsQueryModel queryModel)
        {

            AllCarsFilteredAndPagedServiceModel serviceModel = await this.carService.AllRentalCarsAsync(queryModel);

            queryModel.Cars = serviceModel.Cars;

            queryModel.TotalCars = serviceModel.TotalCarsCount;
            queryModel.CarMakes = await carMakeService.GetAllCarMakesAsync();

            return View(queryModel);
        }

        public async Task<IActionResult> Details(int id)
        {
            bool doesCarExist = await carService.DoesCarExistAsync(id);
  
            if(!doesCarExist)
            {
                TempData[ErrorMessage] = 
                    CarNotifications.CarNotFound;
                return RedirectToAction("All", "Car");
            }

            try
            {
                ICollection<ReviewViewModel> reviews = await reviewService.GetReviewsByCarIdAsync(id);
                ICollection<CarImageViewModel> images = await carImageService.GetImagesByCarIdAsync(id);

                CarDetailViewModel model = await carService.GetCarDetailAsync(id, reviews, images);

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

    }
}
