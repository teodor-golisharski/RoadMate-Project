namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Review;

    using static RoadMateSystem.Common.NotificationMessagesConstants;

    using static RoadMateSystem.Common.NotificationTextConstants;

    public class ReviewController : BaseController
    {
        private readonly IReviewService reviewService;
        private readonly ICarService carService;

        public ReviewController(IReviewService reviewService, ICarService carService)
        {
            this.reviewService = reviewService;
            this.carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> Add(int id)
        {
            bool doesCarExist = await carService.DoesCarExistAsync(id);

            if (!doesCarExist)
            {
                TempData[ErrorMessage] = 
                    CarNotifications.CarNotFound;

                return RedirectToAction("All", "Car");
            }

            try
            {
                ReviewCarViewModel reviewCar = await carService.GetReviewCarViewModelAsync(id);

                ReviewFormModel formModel = await reviewService.GetAddReviewAsync(reviewCar);

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormModel formModel, int id)
        {
            formModel = await reviewService.GetCurrentReviewFormModelAsync(id, formModel);

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = 
                    GeneralErrors.ErrorOccurred;

                return View(formModel);
            }

            try
            {
                await reviewService.AddReviewAsync(formModel, id, GetUserId());

                TempData[SuccessMessage] = 
                    ReviewNotifications.SuccessfullyAdded;

                return RedirectToAction("Details", "Car", new { id = id });
            }
            catch (Exception)
            {
                return GeneralError();
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            ReviewFormModel formModel = await reviewService.GetReviewByIdAsync(id);

            if (formModel == null)
            {
                TempData[ErrorMessage] = 
                    ReviewNotifications.ReviewNotFound;

                return RedirectToAction("All", "Car");
            }

            if (formModel.UserId.ToString() != GetUserId())
            {
                TempData[ErrorMessage] = 
                    ReviewNotifications.NotReviewsOwner;

                return RedirectToAction("Details", "Car", new { id = formModel.CarId });
            }

            try
            {
                ReviewCarViewModel reviewCar = await carService.GetReviewCarViewModelAsync(formModel.CarId);

                formModel.Car = reviewCar;

                return View(formModel);
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ReviewFormModel model)
        {
            int carId = await reviewService.GetCarIdByReviewAsync(id);

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = 
                    GeneralErrors.ErrorOccurred;
            }

            try
            {
                await reviewService.EditReviewAsync(id, model);

                TempData[SuccessMessage] = 
                    ReviewNotifications.SuccessfullyEdited;

                return RedirectToAction("Details", "Car", new { id = carId });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                int carId = await reviewService.GetCarIdByReviewAsync(id);
                
                await reviewService.DeleteReviewAsync(id);

                TempData[WarningMessage] = 
                    ReviewNotifications.ReviewDeleted;

                return RedirectToAction("Details", "Car", new { id = carId });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
