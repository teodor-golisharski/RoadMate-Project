namespace RoadMateSystem.Web.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Web.ViewModels.Car;

    public class ReviewViewModel
    {
        public Guid ReviewId { get; set; }
        public int CarId { get; set; }
        public virtual CarDetailViewModel Car { get; set; } = null!;
        public Guid UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
