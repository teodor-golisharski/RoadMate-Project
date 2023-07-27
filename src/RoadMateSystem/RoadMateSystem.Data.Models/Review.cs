using System.ComponentModel.DataAnnotations;

namespace RoadMateSystem.Data.Models
{
    public class Review
    {
        [Key]
        public Guid ReviewId { get; set; }
        
        public int CarId { get; set; }
        
        public Guid UserId { get; set; }
        
        public int Rating { get; set; }
        
        public string? Comment { get; set; }
        
        public DateTime DatePosted { get; set; }
    }
}
