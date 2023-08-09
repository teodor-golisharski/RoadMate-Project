namespace RoadMateSystem.Web.ViewModels.CarImage
{
    using System.ComponentModel.DataAnnotations.Schema;

    public class ThumbnailImageViewModel
    {
        public int Id { get; set; }
        public string FileUrl { get; set; } = null!;
    }
}
