namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    public class PaymentController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
