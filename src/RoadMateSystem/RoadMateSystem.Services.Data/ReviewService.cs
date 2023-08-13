using Microsoft.EntityFrameworkCore;
using RoadMateSystem.Data.Models;
using RoadMateSystem.Services.Data.Interfaces;
using RoadMateSystem.Web.Data;
using RoadMateSystem.Web.ViewModels.Review;

namespace RoadMateSystem.Services.Data
{
    public class ReviewService : IReviewService
    {
        private readonly RoadMateDbContext dbContext;

        public ReviewService(RoadMateDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<ICollection<ReviewViewModel>> GetReviewsByCarIdAsync(int id)
        {
            ICollection<ReviewViewModel> reviews = await dbContext
                .Reviews
                .Select(r => new ReviewViewModel
                {
                    ReviewId = r.ReviewId.ToString(),
                    CarId = r.Car.Id,
                    UserName = string.Concat(r.User.FirstName, " ", r.User.LastName),
                    Rating = r.Rating,
                    Comment = r.Comment,
                    DatePosted = r.DatePosted
                })
                .Where(x => x.CarId == id)
                .ToListAsync();

            return reviews;
        }

        public async Task AddReview(ReviewFormModel model, int id, string userId)
        {
            Review @review = new Review() 
            { 
                CarId = id,
                UserId = Guid.Parse(userId),
                Rating = model.Rating,
                Comment = model.Comment,
                DatePosted = DateTime.Now, 
            };

            await dbContext.AddAsync(review);
            dbContext.SaveChanges();

        }
    }
}
