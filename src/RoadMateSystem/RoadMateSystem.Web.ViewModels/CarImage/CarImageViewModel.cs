namespace RoadMateSystem.Web.ViewModels.CarImage
{
    public class CarImageViewModel
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = null!;
        public int CarId { get; set; }
    }
}
