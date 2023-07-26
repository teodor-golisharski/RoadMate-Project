namespace RoadMateSystem.Data.Models.Car
{
    public class Car
    {
        public int Id { get; set; }

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public CarType Type { get; set; }

        public FuelType Fuel { get; set; }

        public int ColorId { get; set; }

        public CarColor Color { get; set; } = null!;

        public int Horsepower { get; set; }

        public int EngineCapacity { get; set; }

        public int Seats { get; set; }

        public int Doors { get; set; }

        public string Description { get; set; } = null!;

        public bool Availability { get; set; }

        public Transmission Transmission { get; set; }

        public Drivetrain Drivetrain { get; set; }

        public int MainPhotoId { get; set; }

        public CarImage MainImage { get; set; } = null!;

        public ICollection<CarImage> Images { get; set; } = new HashSet<CarImage>();
    }
}