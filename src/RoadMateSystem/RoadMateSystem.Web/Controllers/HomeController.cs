namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Services.Data;
    using RoadMateSystem.Services.Data.Interfaces;

    public class HomeController : BaseController
    {
        private readonly ICarService carService;

        public HomeController(ICarService carService)
        {
            this.carService = carService;
        }

        public async Task<IActionResult> Index()
        {
            ImagesViewModel model = await carService.PreviewCarImagesAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}