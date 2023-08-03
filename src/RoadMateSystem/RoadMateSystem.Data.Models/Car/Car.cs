namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static Common.EntityValidationConstants.Car;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int CarMakeId { get; set; }

        public virtual CarMake CarMake { get; set; } = null!;

        [Required]
        [StringLength(ModelMaxLength, MinimumLength = ModelMinLength)]
        public string Model { get; set; } = null!;

        [Required]
        public CarType Type { get; set; }

        [Required]
        public FuelType Fuel { get; set; }

        [Required]
        public int ColorId { get; set; }

        [ForeignKey(nameof(ColorId))]
        public virtual CarColor Color { get; set; } = null!;

        [Required]
        [Range(HorsepowerMinValue, HorsepowerMaxValue)]
        public int Horsepower { get; set; }

        [Range(EngineCapacityMinValue, EngineCapacityMaxValue)]
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
        public bool Availability { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        public Drivetrain Drivetrain { get; set; }

        [Required]
        [Range(PricePerDayMinValue, PricePerDayMaxValue)]
        public decimal PricePerDay { get; set; }

        public decimal? PricePerWeek { get; set; }

        public int ThumbnailImageId { get; set; }

        [ForeignKey(nameof(ThumbnailImageId))]
        public virtual CarImage? ThumbnailImage { get; set; }

        public virtual ICollection<CarImage> Images { get; set; } = new HashSet<CarImage>();

        public virtual ICollection<Review> Reviews { get; set; } = new HashSet<Review>();

        public virtual ICollection<Rental> Rentals { get; set; } = new HashSet<Rental>();
    }
}