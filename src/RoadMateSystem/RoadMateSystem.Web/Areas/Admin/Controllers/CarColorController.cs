namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using RoadMateSystem.Web.ViewModels.CarMake;

    using static RoadMateSystem.Common.GeneralApplicationConstants;
    using static RoadMateSystem.Common.NotificationTextConstants;
    using static RoadMateSystem.Common.NotificationMessagesConstants;

    public class CarColorController : BaseAdminController
    {
        private readonly ICarColorService carColorService;

        public CarColorController(ICarColorService carColorService)
        {
            this.carColorService = carColorService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<ColorViewModel> model = await carColorService.GetAllColorsAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            ColorViewModel model = new ColorViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(ColorViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return View(model);
            }

            try
            {
                await carColorService.AddAsync(model);

                TempData[SuccessMessage] =
                CarColorNotifications.SuccessfullyAdded;

                return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ColorViewModel model = await carColorService.GetViewModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(ColorViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
            }
            try
            {
                await carColorService.EditAsync(viewModel.Id, viewModel);

                TempData[SuccessMessage] =
                    CarColorNotifications.SuccessfullyEdited;

                return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
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
                bool doesCarExist = await carColorService.DoesCarColorExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarColorNotifications.ColorNotFound;

                    return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
                }

                await carColorService.DeleteAsync(id);

                TempData[WarningMessage] = CarColorNotifications.ColorDeleted;

                return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
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
                bool doesCarExist = await carColorService.DoesCarColorExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarColorNotifications.ColorNotFound;

                    return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
                }

                await carColorService.RecoverAsync(id);

                TempData[WarningMessage] = CarColorNotifications.ColorRecovered;

                return RedirectToAction("All", "CarColor", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

    }
}

