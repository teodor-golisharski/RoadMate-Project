namespace RoadMateSystem.Services.Data.Interfaces
{
    using RoadMateSystem.Web.ViewModels.CarColor;

    public interface ICarColorService
    {
        Task<IEnumerable<string>> GetAllCarColorsAsync();
    }
}