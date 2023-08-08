namespace RoadMateSystem.Web.ViewModels.Car
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.ViewModels.Review;

    public class CarDetailViewModel
    {
        public int Id { get; set; }
        public int CarMakeId { get; set; }
        public virtual CarMake CarMake { get; set; } = null!;
        public string Model { get; set; } = null!;
        public CarType Type { get; set; }
        public FuelType Fuel { get; set; }
        public int ColorId { get; set; }
        public virtual CarColor Color { get; set; } = null!;
        public int Horsepower { get; set; }
        public int EngineCapacity { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public string Description { get; set; } = null!;
        public Transmission Transmission { get; set; }
        public Drivetrain Drivetrain { get; set; }
        public decimal PricePerDay { get; set; }
        public decimal PricePerWeek { get; set; }
        public int ThumbnailImageId { get; set; }
        public virtual CarImageViewModel? ThumbnailImage { get; set; }

        public virtual ICollection<CarImageViewModel> Images { get; set; } = new HashSet<CarImageViewModel>();

        public virtual ICollection<ReviewViewModel> Reviews { get; set; } = new HashSet<ReviewViewModel>();
    }
}
