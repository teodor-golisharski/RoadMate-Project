namespace RoadMateSystem.Services.Data.Interfaces
{
    public interface ICarMakeService
    {
        Task<IEnumerable<string>> GetAllCarMakesAsync();
    }
}
