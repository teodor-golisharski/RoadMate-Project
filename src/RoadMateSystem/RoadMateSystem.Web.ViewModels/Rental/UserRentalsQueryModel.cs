namespace RoadMateSystem.Web.ViewModels.Rental
{
    using Enums;
    using System.ComponentModel;

    using static RoadMateSystem.Common.GeneralApplicationConstants;

    public class UserRentalsQueryModel
    {
        public UserRentalsQueryModel()
        {
            CurrentPage = DefaultPage;
            RentalsPerPage = EntitiesPerPage;

            Rentals = new HashSet<UserRentalsViewModel>();        
        }

        public IEnumerable<UserRentalsViewModel> Rentals { get; set; }

        [DisplayName("Sort by")]
        public RentalsSorting RentalsSorting { get; set; }
        
        public int CurrentPage { get; set; }

        public int RentalsPerPage { get; set; }

        public int TotalRentals { get; set; }
    }
}
