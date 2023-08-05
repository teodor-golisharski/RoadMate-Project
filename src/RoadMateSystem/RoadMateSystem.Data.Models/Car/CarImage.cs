namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class CarImage
    {
        public CarImage()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string FileName { get; set; } = null!;

        [Required]
        public string FileExtension { get; set; } = null!;
        
        public string? Caption { get; set; }

        [Required]
        public int CarId { get; set; }

        [ForeignKey(nameof(CarId))]
        public virtual Car Car { get; set; } = null!;
    }
}
