namespace RoadMateSystem.Web.ViewModels.Car
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.ComponentModel.DataAnnotations;

    public class CarImageViewModel
    {
        public int Id { get; set; }
        
        public string FileName { get; set; } = null!;
        
        public string FileExtension { get; set; } = null!;
        
        public string? Caption { get; set; }
        
        public int CarId { get; set; }
        
        public virtual CarDetailViewModel Car { get; set; } = null!;
    }
}
