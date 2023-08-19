namespace RoadMateSystem.Data.Models.Payment
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using RoadMateSystem.Data.Models;

    public class Payment
    {
        [Key]
        public Guid PaymentId { get; set; }

        [Required]
        public Guid RentalId { get; set; }

        [ForeignKey(nameof(RentalId))]
        public virtual Rental Rental { get; set; } = null!;

        [Required]
        public DateTime PaymentDate { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public PaymentMethod PaymentMethod { get; set; }

        public bool IsDeleted { get; set; }

    }
}
