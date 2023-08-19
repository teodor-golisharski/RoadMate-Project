namespace RoadMateSystem.Web.ViewModels.CarColor
{
    public class ColorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Hex { get; set; } = null!;
        public bool IsDeleted { get; set; } 
    }
}
