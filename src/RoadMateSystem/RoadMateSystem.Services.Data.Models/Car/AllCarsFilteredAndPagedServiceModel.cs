namespace RoadMateSystem.Services.Data.Models.Car
{
    using RoadMateSystem.Web.ViewModels.Car;

    public class AllCarsFilteredAndPagedServiceModel
    {
        public AllCarsFilteredAndPagedServiceModel()
        {
            this.Cars = new HashSet<AllCarsViewModel>();
        }

        public int TotalCarsCount { get; set; }

        public IEnumerable<AllCarsViewModel> Cars { get; set; }
    }
}
