namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using RoadMateSystem.Web.ViewModels.CarMake;

    using static Common.GeneralApplicationConstants;
    using static Common.NotificationMessagesConstants;
    using static Common.NotificationTextConstants;

    public class CarController : BaseAdminController
    {
        private readonly ICarService carService;
        private readonly ICarMakeService carMakeService;
        private readonly ICarColorService carColorService;
        private readonly IWebHostEnvironment webHostEnvironment;
        public CarController(ICarService carService, ICarMakeService carMakeService, ICarColorService carColorService, IWebHostEnvironment webHostEnvironment)
        {
            this.carService = carService;
            this.carMakeService = carMakeService;
            this.carColorService = carColorService;
            this.webHostEnvironment = webHostEnvironment;
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

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            EditCarViewModel model = await carService.GetCarForEditAsync(id);

            if (model == null)
            {
                TempData[ErrorMessage] = CarNotifications.CarNotFound;
                return RedirectToAction("All", "Car", new { Area = AdminAreaName });
            }

            IEnumerable<ColorViewModel> colorsModel = await carColorService.GetAllColorsAsync();
            IEnumerable<CarMakeViewModel> carMakesModel = await carMakeService.GetAllMakesAsync();

            model.CarColors = colorsModel;
            model.CarMakes = carMakesModel;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditCarViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return RedirectToAction("All", "Car", new { Area = AdminAreaName });
            }
            try
            {
                await carService.EditCarAsync(viewModel.Id, viewModel);

                TempData[SuccessMessage] =
                    CarNotifications.SuccessfullyEdited;

                return RedirectToAction("All", "Car", new { Area = AdminAreaName });
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
                bool doesCarExist = await carService.DoesCarExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarNotifications.CarNotFound;

                    return RedirectToAction("All", "Car", new { Area = AdminAreaName });
                }

                await carService.DeleteAsync(id);

                TempData[WarningMessage] = CarNotifications.CarDeleted;

                return RedirectToAction("Archive", "Car", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Archive([FromQuery] ArchivedCarsQueryModel queryModel)
        {
            AllCarsFilteredAndPagedServiceModel serviceModel = await this.carService.AllArchivedAsync(queryModel);

            queryModel.Cars = serviceModel.Cars;
            queryModel.TotalCars = serviceModel.TotalCarsCount;
            queryModel.CarMakes = await carMakeService.GetAllCarMakesAsync();

            return View(queryModel);
        }

        public async Task<IActionResult> Recover(int id)
        {
            try
            {
                bool doesCarExist = await carService.DoesArchivedCarExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = CarNotifications.CarNotFound;

                    return RedirectToAction("Archive", "Car", new { Area = AdminAreaName });
                }

                await carService.RecoverAsync(id);

                TempData[SuccessMessage] = CarNotifications.CarRecovered;

                return RedirectToAction("All", "Car", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            EditCarViewModel model = new EditCarViewModel();

            IEnumerable<ColorViewModel> colorsModel = await carColorService.GetAllColorsAsync();
            IEnumerable<CarMakeViewModel> carMakesModel = await carMakeService.GetAllMakesAsync();

            model.CarColors = colorsModel;
            model.CarMakes = carMakesModel;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(EditCarViewModel carFormModel)
        {
            string make = await carMakeService.GetMakeByIdAsync(carFormModel.CarMakeId);

            if (!ModelState.IsValid)
            {
                TempData[ErrorMessage] =
                    GeneralErrors.ErrorOccurred;

                return View(carFormModel);
            }

            try
            {
                await carService.AddCarAsync(carFormModel);

                string makeModel = string.Concat(make, carFormModel.Model);

                string carImagesFolderPath = Path.Combine("CarImages", makeModel);


                if (!Directory.Exists(carImagesFolderPath))
                {
                    Directory.CreateDirectory(carImagesFolderPath);
                }

                TempData[SuccessMessage] =
                CarNotifications.SuccessfullyAdded;

                return RedirectToAction("Add", "CarImage", new { Area = AdminAreaName, id=carFormModel.Id });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}

