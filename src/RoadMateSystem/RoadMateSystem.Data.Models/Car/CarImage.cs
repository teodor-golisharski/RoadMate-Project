namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;

    public class CarImage
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FileName { get; set; } = null!;

        [Required]
        public string FileExtension { get; set; } = null!;
        
        public string? Caption { get; set; }
    }
}
