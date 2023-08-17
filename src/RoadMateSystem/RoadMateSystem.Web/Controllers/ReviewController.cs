namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Review;
    using static RoadMateSystem.Common.NotificationMessagesConstants;

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
            ReviewCarViewModel reviewCar = await carService.GetReviewCarViewModelAsync(id);

            ReviewFormModel formModel = await reviewService.GetAddReviewAsync(reviewCar);

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormModel formModel, int id)
        {
            formModel = await reviewService.GetCurrentReviewFormModelAsync(id, formModel);

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Error occurred! Try again later!";
                return View(formModel);
            }

            await reviewService.AddReviewAsync(formModel, id, GetUserId());

            TempData[SuccessMessage] = $"You successfully added a review!";

            return RedirectToAction("Details", "Car", new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            ReviewFormModel formModel = await reviewService.GetReviewByIdAsync(id);

            if(formModel.UserId.ToString() != GetUserId())
            {
                TempData[ErrorMessage] = "You are not the owner of the review!";
                return RedirectToAction("Details", "Car", new { id = formModel.CarId });
            }

            ReviewCarViewModel reviewCar = await carService.GetReviewCarViewModelAsync(formModel.CarId);

            formModel.Car = reviewCar;

            return View(formModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, ReviewFormModel model)
        {
            int carId = await reviewService.GetCarIdByReviewAsync(id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            await reviewService.EditReviewAsync(id, model);

            

            TempData[SuccessMessage] = $"You successfully editted your review!";

            return RedirectToAction("Details", "Car", new { id = carId});
        }

        public async Task<IActionResult> Delete(string id)
        {
            try
            {
                int carId = await reviewService.GetCarIdByReviewAsync(id);
                
                await reviewService.DeleteReviewAsync(id);

                TempData[SuccessMessage] = "You deleted your comment!";

                return RedirectToAction("Details", "Car", new { id = carId });
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
