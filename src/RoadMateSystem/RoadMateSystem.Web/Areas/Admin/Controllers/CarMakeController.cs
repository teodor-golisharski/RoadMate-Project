namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.CarMake;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;
    using static Common.NotificationTextConstants;

    public class CarMakeController : BaseAdminController
    {
        private readonly ICarMakeService carMakeService;

        public CarMakeController(ICarMakeService carMakeService)
        {
            this.carMakeService = carMakeService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<CarMakeViewModel> model = await carMakeService.GetAllMakesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            CarMakeViewModel model = new CarMakeViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarMakeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return View(model);
            }

            try
            {
                await carMakeService.AddAsync(model);
                
                TempData[SuccessMessage] = 
                CarMakeNotifications.SuccessfullyAdded;

                return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            CarMakeViewModel model = await carMakeService.GetViewModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CarMakeViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
            }
            try
            {
                await carMakeService.EditAsync(viewModel.Id, viewModel);

                TempData[SuccessMessage] =
                    CarMakeNotifications.SuccessfullyEdited;

                return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                bool doesCarExist = await carMakeService.DoesCarMakeExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarMakeNotifications.CarMakeNotFound;

                    return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
                }

                await carMakeService.DeleteAsync(id);

                TempData[WarningMessage] = CarMakeNotifications.CarMakeDeleted;

                return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
       
        public async Task<IActionResult> Recover(int id)
        {
            try
            {
                bool doesCarExist = await carMakeService.DoesCarMakeExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarMakeNotifications.CarMakeNotFound;

                    return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
                }

                await carMakeService.RecoverAsync(id);

                TempData[WarningMessage] = CarMakeNotifications.CarMakeRecovered;

                return RedirectToAction("All", "CarMake", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

    }
}
