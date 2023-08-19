namespace RoadMateSystem.Web.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using static Common.GeneralApplicationConstants;
    using static RoadMateSystem.Common.NotificationTextConstants;
    using static RoadMateSystem.Common.NotificationMessagesConstants;

    [Area(AdminAreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class BaseAdminController : Controller
    {
        protected IActionResult GeneralError()
        {
            TempData[ErrorMessage] =
                GeneralErrors.SomethingWentWrong;

            return RedirectToAction("Index", "Home");
        }
    }
}
