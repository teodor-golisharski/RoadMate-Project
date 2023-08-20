namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.User;

    public interface IUserService
    {
        Task<string> GetFullNameByIdAsync(string userId);
        Task<string> GetFullNameByEmailAsync(string email);
        Task<IEnumerable<UserViewModel>> GetAllUsers();
    }
}
