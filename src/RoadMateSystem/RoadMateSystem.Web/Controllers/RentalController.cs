namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Rental;
    using System.Globalization;

    using static RoadMateSystem.Common.NotificationMessagesConstants;


    [Authorize]
    public class RentalController : BaseController
    {
        private readonly IRentalService rentalService;

        public RentalController(IRentalService rentalService)
        {
            this.rentalService = rentalService;
        }

        [HttpGet]
        public async Task<IActionResult> Rent(int id)
        {
            RentalViewModel model = await rentalService.GetRentCarAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Rent(int id, RentalViewModel model)
        {
            if (model.StartDate > model.EndDate)
            {
                ModelState.AddModelError("StartDate", "Start date must be less than or equal to end date.");
                return View(model);
            }

            if (model.StartDate.Date < DateTime.Today)
            {
                ModelState.AddModelError("StartDate", "Start date must be present or future date");
                return View(model);
            }

            IEnumerable<AllRentalsByCarIdViewModel> allRentalsByCarIdViewModels = await rentalService.GetAllRentalsByCarIdAsync(id);

            model = await rentalService.GetCurrentRentCarAsync(id, model);

            bool flag = await rentalService.IsCarAvailableAsync(allRentalsByCarIdViewModels, model);

            if (flag)
            {
                TempData[ErrorMessage] = $"{model.Car!.MakeModel} is unavailable from {model.StartDate.ToString("dd-MMMM-yyyy")} to {model.EndDate.ToString("dd-MMMM-yyyy")}!";

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                TempData[ErrorMessage] = $"Error occurred!";
                return View(model);
            }

            await rentalService.RentCarAsync(model, GetUserId(), id);

            TempData[SuccessMessage] = $"You successfully rented {model.Car!.MakeModel} from {model.StartDate.ToString("dd-MMMM-yyyy")} to {model.EndDate.ToString("dd-MMMM-yyyy")}!";

            return RedirectToAction("Details", "Car", new { id = id });
        }

        public async Task<IActionResult> Mine([FromQuery] UserRentalsQueryModel queryModel)
        {
            string userId = GetUserId();

            AllRentalsFilteredAndPagedServiceModel serviceModel = await rentalService.GetAllRentalsOfUser(queryModel, userId);

            queryModel.Rentals = serviceModel.Rentals;

            return View(queryModel);
        }

    }
}
