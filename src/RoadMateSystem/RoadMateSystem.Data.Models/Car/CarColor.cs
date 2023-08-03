namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;

    using static RoadMateSystem.Common.EntityValidationConstants.CarColor;
    
    public class CarColor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(HexMaxLength, MinimumLength = HexMinLength)]
        public string Hex { get; set; } = null!;
        
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}