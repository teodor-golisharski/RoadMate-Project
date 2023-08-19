namespace RoadMateSystem.Web.Infrastructure.Extensions
{
    using System.Security.Claims;

    using static Common.GeneralApplicationConstants;
    public static class ClaimsPrincipalExtensions
    {
        public static bool IsAdmin(this ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRoleName);
        }
    }
}
