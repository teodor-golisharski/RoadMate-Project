namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Rental;

    using static RoadMateSystem.Common.NotificationMessagesConstants;
    using static RoadMateSystem.Common.NotificationTextConstants;

    [Authorize]
    public class RentalController : BaseController
    {
        private readonly IRentalService rentalService;
        private readonly ICarService carService;

        public RentalController(IRentalService rentalService, ICarService carService)
        {
            this.rentalService = rentalService;
            this.carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> Rent(int id, DateTime startDate, DateTime endDate)
        {

            bool doesCarExist = await carService.DoesCarExistAsync(id);

            if (!doesCarExist)
            {
                TempData[ErrorMessage] = 
                    CarNotifications.CarNotFound;

                return RedirectToAction("RentalCars", "Car");
            }

            try
            {
                RentalViewModel model = await rentalService.GetRentCarAsync(id);

                model.StartDate = startDate;
                model.EndDate = endDate;

                return View(model);
            }
            catch (Exception)
            {
                return GeneralError();
            }
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
                TempData[WarningMessage] =
                    $"{model.Car!.MakeModel} is unavailable from {model.StartDate.ToString("dd-MMMM-yyyy")} to {model.EndDate.ToString("dd-MMMM-yyyy")}!";

                return View(model);
            }

            if (ModelState.IsValid == false)
            {
                TempData[ErrorMessage] = 
                    GeneralErrors.ErrorOccurred;

                return View(model);
            }

            try
            {
                await rentalService.RentCarAsync(model, GetUserId(), id);

                TempData[SuccessMessage] = $"You successfully rented {model.Car!.MakeModel} from {model.StartDate.ToString("dd-MMMM-yyyy")} to {model.EndDate.ToString("dd-MMMM-yyyy")}!";

                return RedirectToAction("Mine", "Rental", new { RentalsSorting = 1 });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Mine([FromQuery] UserRentalsQueryModel queryModel)
        {
            string userId = GetUserId();

            AllRentalsFilteredAndPagedServiceModel serviceModel = await rentalService.GetAllRentalsOfUser(queryModel, userId);

            queryModel.Rentals = serviceModel.Rentals;
            queryModel.TotalRentals = serviceModel.TotalRentals;

            return View(queryModel);
        }

        [HttpGet]
        public async Task<IActionResult> Search()
        {
            await Task.Yield();

            SearchViewModel model = new SearchViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Search(SearchViewModel model)
        {
            await Task.Yield();

            RentalCarsQueryModel queryModel = new RentalCarsQueryModel();

            queryModel.StartDate = model.StartDate;
            queryModel.EndDate = model.EndDate;

            return RedirectToAction("RentalCars", "Car", queryModel);
        }
    }
}
