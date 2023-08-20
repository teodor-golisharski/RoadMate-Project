namespace RoadMateSystem.Services.Data
{
    using Ganss.Xss;
    using Microsoft.EntityFrameworkCore;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Services.Data.Interfaces;
    using RoadMateSystem.Web.Data;
    using RoadMateSystem.Web.ViewModels.User;

    public class UserService : IUserService
    {
        private readonly RoadMateDbContext dbContext;
        private readonly HtmlSanitizer sanitizer;

        public UserService(RoadMateDbContext dbContext, HtmlSanitizer sanitizer)
        {
            this.dbContext = dbContext;
            this.sanitizer = sanitizer;

        }

        public async Task<string> GetFullNameByIdAsync(string userId)
        {
            ApplicationUser? user = await this.dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Id.ToString() == userId);
            if (user == null)
            {
                return string.Empty;
            }

            return sanitizer.Sanitize($"{user.FirstName} {user.LastName}");
        }

        public async Task<string> GetFullNameByEmailAsync(string email)
        {
            ApplicationUser? user = await this.dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return string.Empty;
            }

            return sanitizer.Sanitize($"{user.FirstName} {user.LastName}");
        }

        public async Task<IEnumerable<UserViewModel>> GetAllUsers()
        {
            IEnumerable<UserViewModel> userViewModels = await dbContext
                .Users
                .Select(x => new UserViewModel
                {
                    Address = x.Address,
                    Email = x.Email,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Phone = x.Phone
                })
                .ToListAsync();

            return userViewModels;
        }

    }
}
