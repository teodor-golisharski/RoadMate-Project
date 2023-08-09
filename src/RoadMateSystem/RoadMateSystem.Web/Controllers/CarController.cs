namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.ViewModels.Car;

    [Authorize]
    public class CarController : Controller
    {
        private readonly ICarService carService;

        public CarController(ICarService carService)
        {
            this.carService = carService;
        }

        public async Task<IActionResult> All()
        {
            IEnumerable<AllCarsViewModel> model = await carService.GetAllCarsAsync();

            return View(model);
        }

        public async Task<IActionResult> Edit()
        {
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            CarDetailViewModel model = await carService.GetCarDetailAsync(id);

            return View(model);
        }
    }
}
