namespace RoadMateSystem.Web.ViewModels.Car
{
    public class CarColorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Hex { get; set; } = null!;
        public int CarId { get; set; }
    }
}
