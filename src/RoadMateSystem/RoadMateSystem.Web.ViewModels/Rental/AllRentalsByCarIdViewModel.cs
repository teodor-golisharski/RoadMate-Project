namespace RoadMateSystem.Web.ViewModels.Rental
{
    using System.ComponentModel.DataAnnotations;

    public class AllRentalsByCarIdViewModel
    {
        public Guid RentalId { get; set; }
        public int CarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
