namespace RoadMateSystem.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<string> GetFullNameByIdAsync(string userId);
        Task<string> GetFullNameByEmailAsync(string email);
    }
}
