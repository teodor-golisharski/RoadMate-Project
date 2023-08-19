namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;

    public class CarMakeEntityConfiguration : IEntityTypeConfiguration<CarMake>
    {
        public void Configure(EntityTypeBuilder<CarMake> builder)
        {
            builder
                .Property(b => b.IsDeleted)
                .HasDefaultValue(false);

            builder.HasData(this.GenerateCarMakes());
        }

        private CarMake[] GenerateCarMakes()
        {
            ICollection<CarMake> carMakes = new HashSet<CarMake>();

            CarMake carMake;

            carMake = new CarMake()
            {
                Id = 1,
                Make = "Renault"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 2,
                Make = "Dacia"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 3,
                Make = "Ford"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 4,
                Make = "Honda"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 5,
                Make = "Peugeot"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 6,
                Make = "Skoda"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 7,
                Make = "Volkswagen"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 8,
                Make = "Toyota"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 9,
                Make = "Mazda"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 10,
                Make = "BMW"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 11,
                Make = "Audi"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 12,
                Make = "Mercedes-Benz"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 13,
                Make = "Porsche"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 14,
                Make = "Range Rover"
            };
            carMakes.Add(carMake);

            carMake = new CarMake()
            {
                Id = 15,
                Make = "Maserati"
            };
            carMakes.Add(carMake);

            return carMakes.ToArray();
        }

    }
}
