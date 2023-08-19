namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.ViewModels.Rental;

    public class RentalController : BaseAdminController
    {
        private readonly IRentalService rentalService;
        public RentalController(IRentalService rentalService)
        {
             this.rentalService = rentalService;
        }

        public async Task<IActionResult> All([FromQuery] UserRentalsQueryModel queryModel)
        {
            AllRentalsFilteredAndPagedServiceModel serviceModel = await rentalService.GetAllRentalsAsync(queryModel);

            queryModel.Rentals = serviceModel.Rentals;
            queryModel.TotalRentals = serviceModel.TotalRentals;

            return View(queryModel);
        }

    }
}
