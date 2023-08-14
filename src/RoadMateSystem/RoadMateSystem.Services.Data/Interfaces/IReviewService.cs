namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.Car;
    using RoadMateSystem.Web.ViewModels.Review;

    public interface IReviewService
    {
        Task<ICollection<ReviewViewModel>> GetReviewsByCarIdAsync(int id);

        Task AddReviewAsync(ReviewFormModel model, int id, string userId);

        Task<ReviewFormModel> GetAddReviewAsync(ReviewCarViewModel reviewCar);

        Task<ReviewFormModel> GetCurrentReviewFormModelAsync(int id, ReviewFormModel formModel);

        Task DeleteReviewAsync(string id);

        Task<int> GetCarIdByReviewAsync(string reviewId);

        Task<ReviewFormModel> GetReviewByIdAsync(string reviewId);

        Task EditReviewAsync(string id, ReviewFormModel model);
    }
}
