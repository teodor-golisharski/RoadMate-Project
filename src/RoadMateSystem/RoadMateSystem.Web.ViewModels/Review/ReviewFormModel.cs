namespace RoadMateSystem.Web.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Data.Models.Car;
    using static RoadMateSystem.Common.EntityValidationConstants.Review;
    using RoadMateSystem.Web.ViewModels.Car;

    public class ReviewFormModel
    {
        public Guid ReviewId { get; set; }

        [Required]
        public int CarId { get; set; }

        public ReviewCarViewModel? Car { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        [Range(RatingMinValue, RatingMaxValue)]
        public int Rating { get; set; }

        [MaxLength(CommentMaxValue)]
        public string? Comment { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }
    }
}
