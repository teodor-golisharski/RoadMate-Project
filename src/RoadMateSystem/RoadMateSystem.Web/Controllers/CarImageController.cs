namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class CarImageController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
