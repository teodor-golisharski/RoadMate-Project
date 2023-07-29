namespace RoadMateSystem.Data.Models.Car
{
    using System.ComponentModel.DataAnnotations;
    
    public class CarColor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Hex { get; set; } = null!;
        
        public virtual ICollection<Car> Cars { get; set; } = new HashSet<Car>();
    }
}