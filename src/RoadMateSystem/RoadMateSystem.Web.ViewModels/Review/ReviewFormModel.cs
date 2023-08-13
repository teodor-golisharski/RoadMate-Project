namespace RoadMateSystem.Web.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Data.Models.Car;
    using static RoadMateSystem.Common.EntityValidationConstants.Review;

    public class ReviewFormModel
    {
        public Guid ReviewId { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public virtual Car Car { get; set; } = null!;

        [Required]
        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        [Required]
        [Range(RatingMinValue, RatingMaxValue)]
        public int Rating { get; set; }

        [MaxLength(CommentMaxValue)]
        public string? Comment { get; set; }

        [Required]
        public DateTime DatePosted { get; set; }
    }
}
