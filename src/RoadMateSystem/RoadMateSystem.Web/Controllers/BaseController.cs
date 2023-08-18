namespace RoadMateSystem.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    using static Common.NotificationMessagesConstants;
    using static Common.NotificationTextConstants;

    public class BaseController : Controller
    {
        protected string GetUserId()
        {
            string id = string.Empty;

            if (User != null)
            {
                id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return id;
        }

        protected IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                GeneralErrors.SomethingWentWrong;

            return RedirectToAction("Index", "Home");
        }
    }
}
