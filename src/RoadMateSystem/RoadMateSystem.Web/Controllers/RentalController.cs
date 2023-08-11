namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ModelBinding;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Rental;
    using System.Globalization;

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
            model = await rentalService.GetCurrentRentCarAsync(id, model);

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

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await rentalService.RentCarAsync(model, GetUserId(), id);

            return RedirectToAction("Details", "Car", new { id = id });
        }

        public async Task<IActionResult> Mine()
        {
            return View();
        }

        public async Task<IActionResult> Available()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            return View();
        }
    }
}
