namespace RoadMateSystem.Web.ViewModels.Car
{
    using RoadMateSystem.Data.Models.Car;

    public class ReviewCarViewModel
    {
        public int Id { get; set; }
        public string MakeModel { get; set; } = null!;
        public CarType CarType { get; set; }
        public FuelType Fuel { get; set; }
        public string? Color { get; set; }
        public int Horsepower { get; set; }
        public int Seats { get; set; }
        public string ThumbnailImageUrl { get; set; } = null!;
    }
}
