namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Services.Data.Models.Rentals;
    using RoadMateSystem.Web.ViewModels.Rental;

    using static Common.NotificationMessagesConstants;
    using static Common.GeneralApplicationConstants;
    using static RoadMateSystem.Common.NotificationTextConstants;

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
        
        public async Task<IActionResult> Pay(string id)
        {
            try
            {
                await rentalService.UserPaidAsync(id);

                TempData[SuccessMessage] = "Payment registered!";

                return RedirectToAction("All", "Rental", new { Area = AdminAreaName });
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
                bool doesRentalExist = await rentalService.DoesRentalExistAsync(id);

                if (!doesRentalExist)
                {
                    TempData[ErrorMessage] = RentalNotifications.RentalNotFound;

                    return RedirectToAction("All", "Rental", new { Area = AdminAreaName });
                }

                await rentalService.DeleteAsync(id);

                TempData[WarningMessage] = RentalNotifications.RentalNotFound;

                return RedirectToAction("All", "Rental", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }

        public async Task<IActionResult> Recover(string id)
        {
            try
            {
                bool doesCarExist = await rentalService.DoesRentalExistAsync(id);

                if (!doesCarExist)
                {
                    TempData[ErrorMessage] = RentalNotifications.RentalNotFound;

                    return RedirectToAction("All", "Rental", new { Area = AdminAreaName });
                }

                await rentalService.RecoverAsync(id);

                TempData[WarningMessage] = RentalNotifications.RentalNotFound;

                return RedirectToAction("All", "Rental", new { Area = AdminAreaName });
            }
            catch (Exception)
            {
                return GeneralError();
            }
        }
    }
}
