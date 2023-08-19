namespace RoadMateSystem.Web.ViewModels.Car
{
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.CarColor;
    using RoadMateSystem.Web.ViewModels.CarMake;
    using System.ComponentModel.DataAnnotations;

    using static RoadMateSystem.Common.EntityValidationConstants.Car;

    public class EditCarViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Car Make")]
        public int CarMakeId { get; set; }

        public IEnumerable<CarMakeViewModel> CarMakes { get; set; } = new List<CarMakeViewModel>();

        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; set; } = null!;

        [Required]
        [Display(Name = "Car Type")]
        public CarType Type { get; set; }

        [Required]
        public FuelType Fuel { get; set; }

        [Required]
        [Display(Name = "Car Color")]
        public int ColorId { get; set; }

        public IEnumerable<ColorViewModel> CarColors { get; set; } = new List<ColorViewModel>();

        [Required]
        [Range(HorsepowerMinValue, HorsepowerMaxValue)]
        public int Horsepower { get; set; }

        [Range(EngineCapacityMinValue, EngineCapacityMaxValue)]
        [Display(Name = "EngineCapacity")]
        public int EngineCapacity { get; set; }

        [Required]
        [Range(SeatsMinValue, SeatsMaxValue)]
        public int Seats { get; set; }

        [Required]
        [Range(DoorsMinValue, DoorsMaxValue)]
        public int Doors { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Display(Name = "Transmission")]
        public Transmission Transmission { get; set; }

        [Required]
        [Display(Name = "Drivetrain")]
        public Drivetrain Drivetrain { get; set; }

        [Required]
        [Range(PricePerDayMinValue, PricePerDayMaxValue)]
        [Display(Name = "Daily Price")]
        public decimal PricePerDay { get; set; }

        [Required]
        [Display(Name = "Weekly Price")]
        public decimal PricePerWeek { get; set; }
    }
}
