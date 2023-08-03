namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;

    using static Common.EntityValidationConstants.Car;

    public class CarMake
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(MakeMaxLength, MinimumLength = MakeMinLength)]
        public string Make { get; set; } = null!;

        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}
