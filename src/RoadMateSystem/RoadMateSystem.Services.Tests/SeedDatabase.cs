namespace RoadMateSystem.Services.Tests
{
    using RoadMateSystem.Data.Models.Car;
    using RoadMateSystem.Web.Data;

    public static class SeedDatabase
    {
        public static CarMake Make;
        
        public static void Seed(RoadMateDbContext dbContext)
        {

            Make = new CarMake()
            {
                Id = 16,
                Make = "Lada"
            };
            dbContext.CarMakes.Add(Make);

            dbContext.SaveChanges();
        }
    }
}
