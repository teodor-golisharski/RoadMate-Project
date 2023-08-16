namespace RoadMateSystem.Services.Data.Models.Rentals
{
    using RoadMateSystem.Web.ViewModels.Rental;

    public class AllRentalsFilteredAndPagedServiceModel
    {
        public AllRentalsFilteredAndPagedServiceModel()
        {
            Rentals = new HashSet<UserRentalsViewModel>();
        }
        public IEnumerable<UserRentalsViewModel> Rentals { get; set; } 
        public int TotalRentals { get; set; }
    }
}
