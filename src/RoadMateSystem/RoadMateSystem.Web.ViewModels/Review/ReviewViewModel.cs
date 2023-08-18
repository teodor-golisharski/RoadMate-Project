namespace RoadMateSystem.Web.ViewModels.Review
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Web.ViewModels.Car;

    public class ReviewViewModel
    {
        public string ReviewId { get; set; } = null!;
        public int CarId { get; set; }
        public string UserId { get; set; } = null!;
        public string UserName  { get; set; } = null!;
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
