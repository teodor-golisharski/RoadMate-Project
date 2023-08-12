namespace RoadMateSystem.Web.ViewModels.Rental
{
    public class HybridRentalViewModel
    {
        public IEnumerable<AllRentalsByCarIdViewModel> RentedDays { get; set; } = new  List<AllRentalsByCarIdViewModel>();

        public RentalViewModel RentalViewModel { get; set; } = null!;
    }
}
