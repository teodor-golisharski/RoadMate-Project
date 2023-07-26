namespace RoadMateSystem.Data.Models.Car
{
    public class CarImage
    {
        public int Id { get; set; }
        public string FileName { get; set; } = null!;
        public string FileExtension { get; set; } = null!;
        public string? Caption { get; set; }
    }
}
