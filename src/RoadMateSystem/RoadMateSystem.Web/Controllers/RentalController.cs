namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize]
    public class RentalController : Controller
    {
        public async Task<IActionResult> Rent()
        {
            return View();
        }

        public async Task<IActionResult> Mine()
        {
            return View();
        }

        public async Task<IActionResult> All()
        {
            return View();
        }
    }
}
