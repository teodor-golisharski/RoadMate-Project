namespace RoadMateSystem.Web.ViewModels.Home
{
    using System.ComponentModel.DataAnnotations;

    public class ImageViewModel
    {
        public int Id { get; set; }

        [Required]
        public string FileUrl { get; set; } = null!;
    }
}
