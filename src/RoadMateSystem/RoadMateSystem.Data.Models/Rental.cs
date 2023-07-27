using System.ComponentModel.DataAnnotations;

namespace RoadMateSystem.Data.Models
{
    public class Rental
    {
        [Key]
        public Guid RentalId { get; set; }
        
        public int CarId { get; set; }
        
        public Guid UserId { get; set; }
        
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
        
        public decimal TotalCost { get; set; }
        
        public bool IsPaid { get; set; }
    }
}
