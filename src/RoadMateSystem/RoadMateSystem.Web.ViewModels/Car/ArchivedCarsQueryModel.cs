namespace RoadMateSystem.Web.ViewModels.Car
{
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Car.Enums;
    using System.ComponentModel.DataAnnotations;

    using static RoadMateSystem.Common.GeneralApplicationConstants;

    public class ArchivedCarsQueryModel
    {
        public ArchivedCarsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.CarsPerPage = EntitiesPerPage;

            this.CarSorting = CarSorting.Relevance;

            this.CarMakes = new HashSet<string>();
            this.Cars = new HashSet<AllCarsViewModel>();
        }

        [Display(Name = "Car Type")]
        public CarType? CarType { get; set; }

        [Display(Name = "Fuel Type")]
        public FuelType? FuelType { get; set; }

        public Transmission? Transmission { get; set; }

        public Drivetrain? Drivetrain { get; set; }

        public string? CarMake { get; set; }

        public IEnumerable<string> CarMakes { get; set; } = null!;

        [Display(Name = "Sort Cars By")]
        public CarSorting CarSorting { get; set; }

        public int CurrentPage { get; set; }

        public int CarsPerPage { get; set; }

        public int TotalCars { get; set; }

        public IEnumerable<AllCarsViewModel> Cars { get; set; }
    }
}
