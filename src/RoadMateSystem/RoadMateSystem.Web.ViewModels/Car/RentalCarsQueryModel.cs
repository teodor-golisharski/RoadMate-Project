namespace RoadMateSystem.Web.ViewModels.Car
{
    using System.ComponentModel.DataAnnotations;
    
    using RoadMateSystem.Data.Models.Car;
    using Enums;

    using static RoadMateSystem.Common.GeneralApplicationConstants;

    public class RentalCarsQueryModel
    {
        public RentalCarsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.CarsPerPage = EntitiesPerPage;

            this.CarMakes = new HashSet<string>();
            this.Cars = new HashSet<AllCarsViewModel>();

        }

        [Display(Name = "Fuel Type")]
        public FuelType? FuelType { get; set; }

        public Transmission? Transmission { get; set; }

        [Display(Name = "Car Make")]
        public string? CarMake { get; set; }

        public IEnumerable<string> CarMakes { get; set; } = null!;

        [Display(Name = "Minimum Daily Price")]
        public MinimumPrice MinimumPrice { get; set; }

        [Display(Name = "Maximum Daily Price")]
        public MaximumPrice MaximumPrice { get; set; }

        [Display(Name = "Sort Cars By")]
        public CarSorting CarSorting { get; set; }

        [Display(Name ="Start Date")]
        [Required(ErrorMessage = "Please select a start date!")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Please select an end date!")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public int CurrentPage { get; set; }

        public int CarsPerPage { get; set; }

        public int TotalCars { get; set; }

        public IEnumerable<AllCarsViewModel> Cars { get; set; }
    }
}
