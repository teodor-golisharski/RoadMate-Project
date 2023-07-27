using System.ComponentModel.DataAnnotations;

namespace RoadMateSystem.Data.Models.Car
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Make { get; set; } = null!;

        [Required]

        public string Model { get; set; } = null!;

        [Required]
        public CarType Type { get; set; }

        [Required]
        public FuelType Fuel { get; set; }

        [Required]
        public int ColorId { get; set; }

        public CarColor Color { get; set; } = null!;

        [Required]
        public int Horsepower { get; set; }

        [Required]
        public int EngineCapacity { get; set; }

        [Required]
        public int Seats { get; set; }

        [Required]
        public int Doors { get; set; }

        public string Description { get; set; } = null!;

        [Required]
        public bool Availability { get; set; }

        [Required]
        public Transmission Transmission { get; set; }

        [Required]
        public Drivetrain Drivetrain { get; set; }

        [Required]
        public decimal PricePerDay { get; set; }

        public decimal PricePerWeek { get; set; }
        
        public int ThumbnailImageId { get; set; }

        public CarImage ThumbnailImage { get; set; } = null!;

        public ICollection<CarImage> Images { get; set; } = new HashSet<CarImage>();
    }
}