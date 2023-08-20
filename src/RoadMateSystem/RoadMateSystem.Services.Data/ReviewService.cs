using Microsoft.EntityFrameworkCore;
using RoadMateSystem.Data.Models;
using RoadMateSystem.Services.Data.Interfaces;
using RoadMateSystem.Web.Data;
using RoadMateSystem.Web.ViewModels.Car;
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
                    UserId = r.UserId.ToString(),
                    UserName = string.Concat(r.User.FirstName, " ", r.User.LastName),
                    Rating = r.Rating,
                    Comment = r.Comment,
                    DatePosted = r.DatePosted
                })
                .Where(x => x.CarId == id)
                .ToListAsync();

            return reviews;
        }

        public async Task<ReviewFormModel> GetAddReviewAsync(ReviewCarViewModel reviewCar)
        {
            await Task.Yield();

            ReviewFormModel formModel = new ReviewFormModel()
            {
                CarId = reviewCar.Id,
                Car = reviewCar
            };

            return formModel;
        }

        public async Task<ReviewFormModel> GetCurrentReviewFormModelAsync(int id, ReviewFormModel formModel)
        {
            await Task.Yield();

            formModel = new ReviewFormModel()
            {
                CarId = id,
                Comment = formModel.Comment,
                Rating = formModel.Rating,
            };

            return formModel;
        }

        public async Task AddReviewAsync(ReviewFormModel model, int id, string userId)
        {
            Review review = new Review() 
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

        public async Task DeleteReviewAsync(string id)
        {
            var review = await dbContext
                .Reviews
                .FirstAsync(r => r.ReviewId == Guid.Parse(id));

            dbContext.Reviews.Remove(review);
            await dbContext.SaveChangesAsync();
        }

        public async Task<int> GetCarIdByReviewAsync(string reviewId)
        {
            ReviewCarIdViewModel view = await dbContext
                .Reviews
                .Select(r => new ReviewCarIdViewModel
                {
                    ReviewId = r.ReviewId.ToString(),
                    CarId = r.CarId,
                })
                .FirstAsync(r => r.ReviewId == reviewId);

            int id = view.CarId;

            return id;
        }

        public async Task<ReviewFormModel> GetReviewByIdAsync(string reviewId)
        {
            ReviewFormModel formModel = await dbContext
                .Reviews
                .Select(r => new ReviewFormModel 
                { 
                    ReviewId = r.ReviewId,
                    CarId = r.CarId,
                    DatePosted = r.DatePosted,
                    Rating = r.Rating,
                    Comment = r.Comment,
                    UserId = r.UserId
                })
                .FirstAsync(r => r.ReviewId == Guid.Parse(reviewId));

            return formModel;
        }

        public async Task EditReviewAsync(string reviewId, ReviewFormModel model)
        {
            var review = await dbContext.Reviews.FindAsync(Guid.Parse(reviewId));

            if(review != null)
            {
                review.Comment = model.Comment;
                review.Rating = model.Rating;
                review.DatePosted = DateTime.Now;
                
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
