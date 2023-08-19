namespace RoadMateSystem.Web.ViewModels.Car
{
    using RoadMateSystem.Data.Models.Car;

    public class RentCarViewModel
    {
        public int Id { get; set; }
        public string MakeModel { get; set; } = null!;
        public CarType CarType { get; set; }
        public int Horsepower { get; set; }
        public FuelType Fuel { get; set; }
        public Transmission Transmission { get; set; }

        public string Description { get; set; } = null!;
        public decimal PricePerWeek { get; set; }
        public decimal PricePerDay { get; set; }
        public string ThumbnailImageUrl { get; set; } = null!;
        public bool IsDeleted { get; set; }

    }
}
