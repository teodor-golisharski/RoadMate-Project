using Microsoft.EntityFrameworkCore;
using RoadMateSystem.Services.Data.Interfaces;
using RoadMateSystem.Web.Data;
using RoadMateSystem.Web.ViewModels.Review;

namespace RoadMateSystem.Services.Data
{
    public class ReviewService : IReviewService
    {
        private readonly RoadMateDbContext _dbContext;

        public ReviewService(RoadMateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<ReviewViewModel>> GetReviewsForCarAsync(int carId)
        {
            return await _dbContext
                .Reviews
                .Select(r => new ReviewViewModel
                {
                    ReviewId = r.ReviewId.ToString(),
                    CarId = r.CarId,
                    UserName = string.Concat(r.User.FirstName, " ", r.User.LastName),
                    Rating = r.Rating,
                    Comment = r.Comment,
                    DatePosted = r.DatePosted,
                })
                .Where(r => r.CarId == carId)
                .ToListAsync();
        }
    }
}
