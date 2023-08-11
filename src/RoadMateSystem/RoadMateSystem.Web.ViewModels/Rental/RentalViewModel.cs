namespace RoadMateSystem.Web.ViewModels.Rental
{
    using System.ComponentModel.DataAnnotations;
    using RoadMateSystem.Data.Models;
    using RoadMateSystem.Web.ViewModels.Car;

    public class RentalViewModel
    {
        [Key]
        public Guid RentalId { get; set; }

        [Required]
        public int CarId { get; set; }

        public RentCarViewModel? Car { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        
        public decimal TotalCost { get; set; }
    }
}
