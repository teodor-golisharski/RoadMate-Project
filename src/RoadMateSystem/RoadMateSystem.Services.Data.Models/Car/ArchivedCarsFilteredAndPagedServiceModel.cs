namespace RoadMateSystem.Services.Data.Models.Car
{
    using RoadMateSystem.Web.ViewModels.Car;

    public class ArchivedCarsFilteredAndPagedServiceModel
    {
        public ArchivedCarsFilteredAndPagedServiceModel()
        {
            this.Cars = new HashSet<AllCarsViewModel>();
        }

        public int TotalCarsCount { get; set; }

        public IEnumerable<AllCarsViewModel> Cars { get; set; }
    }
}
