namespace RoadMateSystem.Web.ViewModels.Car
{
    using System.ComponentModel.DataAnnotations;
    using RoadMateSystem.Data.Models.Car;

    using static Common.GeneralApplicationConstants;
    using static Common.EntityValidationConstants.Car;

    using Enums;

    public class AllCarsQueryModel
    {
        public AllCarsQueryModel()
        {
            this.CurrentPage = DefaultPage;
            this.CarsPerPage = EntitiesPerPage;

            this.MaxHorsepower = HorsepowerMaxValue;
            this.MinHorsepower = HorsepowerMinValue;

            this.CarMakes = new HashSet<string>();
            this.Colors = new HashSet<string>();
            this.Cars = new HashSet<AllCarsViewModel>();
        }

        [Display(Name = "Car Type")]
        public CarType? CarType { get; set; }

        [Display(Name = "Fuel Type")]
        public FuelType? FuelType { get; set; }

        public Transmission? Transmission { get; set; }

        public Drivetrain? Drivetrain { get; set; }

        public string? Color { get; set; }

        public IEnumerable<string> Colors { get; set; } = null!;

        public string? CarMake { get; set; }

        public IEnumerable<string> CarMakes { get; set; } = null!;

        [Display(Name = "Minimum Daily Price")]
        public MinimumPrice MinimumPrice { get; set; }

        [Display(Name = "Maximum Daily Price")]
        public MaximumPrice MaximumPrice { get; set; }

        [Display(Name = "Minimum Horsepower")]
        public int MinHorsepower { get; set; }

        [Display(Name = "Maximum Horsepower")]
        public int MaxHorsepower { get; set; }

        [Display(Name = "Sort Cars By")]
        public CarSorting CarSorting { get; set; }

        public int CurrentPage { get; set; }

        public int CarsPerPage { get; set; }

        public int TotalCars { get; set; }

        public IEnumerable<AllCarsViewModel> Cars { get; set; }
    }
}
