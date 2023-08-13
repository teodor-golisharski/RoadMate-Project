namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Review;
    using static RoadMateSystem.Common.NotificationMessagesConstants;

    public class ReviewController : BaseController
    {
        private readonly IReviewService reviewService;
        public ReviewController(IReviewService reviewService)
        {
            this.reviewService = reviewService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(ReviewFormModel formModel, int id, string userId)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] = "Error occurred!";
            }

            await reviewService.AddReview(formModel, id, userId);

            TempData[SuccessMessage] = $"You successfully added a review!";

            return RedirectToAction("Details", "Car", new { id = id });
        }

        public async Task<IActionResult> Edit()
        {
            return View();
        }

        public async Task<IActionResult> Delete()
        {
            return View();
        }
    }
}
