using System.ComponentModel.DataAnnotations;

namespace RoadMateSystem.Data.Models
{
    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }
        public Guid RentalId { get; set; }
        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMethod { get; set; } = null!;
    }
}
