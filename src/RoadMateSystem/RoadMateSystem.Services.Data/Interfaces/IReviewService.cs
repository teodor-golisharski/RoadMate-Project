namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Review;

    public interface IReviewService
    {
        Task<ICollection<ReviewViewModel>> GetReviewsByCarIdAsync(int id);

        Task AddReview(ReviewFormModel model, int id, string userId);
    }
}
