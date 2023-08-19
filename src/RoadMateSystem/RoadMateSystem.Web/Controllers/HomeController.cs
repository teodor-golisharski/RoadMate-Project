namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using RoadMateSystem.Web.ViewModels.Home;
    using RoadMateSystem.Services.Data.Interfaces;

    using static Common.GeneralApplicationConstants;

    public class HomeController : BaseController
    {
        private readonly ICarService carService;

        public HomeController(ICarService carService)
        {
            this.carService = carService;
        }

        public async Task<IActionResult> Index()
        {
            if(this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { Area = AdminAreaName });
            }    

            ImagesViewModel model = await carService.PreviewCarImagesAsync();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400 || statusCode == 404)
            {
                return View("Error404");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}