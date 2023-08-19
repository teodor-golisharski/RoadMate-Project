namespace RoadMateSystem.Web.ViewModels.Car
{
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Review;
    using RoadMateSystem.Web.ViewModels.CarImage;
    using RoadMateSystem.Web.ViewModels.CarColor;

    public class CarDetailViewModel
    {
        public int Id { get; set; }
        public string CarMake { get; set; } = null!;
        public string Model { get; set; } = null!;
        public CarType Type { get; set; }
        public FuelType Fuel { get; set; }
        public CarColorViewModel Color { get; set; } = null!;
        public int Horsepower { get; set; }
        public int EngineCapacity { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public string Description { get; set; } = null!;
        public Transmission Transmission { get; set; }
        public Drivetrain Drivetrain { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PricePerWeek { get; set; }
        public string ThumbnailUrl { get; set; } = null!;
        public bool IsDeleted { get; set; }


        public virtual IEnumerable<CarImageViewModel> Images { get; set; } = new List<CarImageViewModel>();

        public virtual IEnumerable<ReviewViewModel> Reviews { get; set; } = new List<ReviewViewModel>();

    }
}
