namespace RoadMateSystem.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    using static Common.EntityValidationConstants.Review;

    public class Review
    {
        public Review()
        {
            ReviewId = Guid.NewGuid();    
        }

        [Key]
        public Guid ReviewId { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public virtual Car.Car Car { get; set; } = null!;

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
