namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;

    public class CarImageEntityConfiguration : IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            //builder.HasOne(b => b.Car)
            //    .WithMany(b => b.Images)
            //    .HasForeignKey(b => b.CarId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData(GenerateCarImages());
        }

        private CarImage[] GenerateCarImages()
        {
            ICollection<CarImage> carImages = new HashSet<CarImage>();

            CarImage carImage;

            // CarId = 1 (Renault Clio)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 1
            });

            // CarId = 2 (Dacia Duster)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 2
            });

            // CarId = 3 (Ford Fiesta)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 3
            });

            // CarId = 4 (Honda Jazz)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 4
            });

            // CarId = 5 (Peugeot 308)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 5
            });

            // CarId = 6 (Skoda Fabia)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 6
            });

            // CarId = 7 (Volkswagen Golf)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 7
            });

            // CarId = 8 (Dacia Spring)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 8
            });

            // CarId = 9 (Volkswagen T-Cross)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 9
            });

            // CarId = 10 (Toyota Corolla)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 10
            });

            // CarId = 11 (Skoda Octavia)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 11
            });

            // CarId = 12 (Skoda Superb)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 12
            });

            // CarId = 13 (Volkswagen Passat)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 13
            });

            // CarId = 14 (Volkswagen Touareg)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 14
            });

            // CarId = 15 (Peugeot 508)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 15
            });

            // CarId = 16 (Peugeot 3008)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 16
            });

            // CarId = 17 (Mazda 6)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 17
            });

            // CarId = 18 (Mazda CX-5)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 18
            });

            // CarId = 19 (BMW 120d)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 19
            });

            // CarId = 20 (Audi A4 Allroad)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 20
            });

            // CarId = 21 (Mercedes-Benz GT63 S)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 21
            });

            // CarId = 22 (Mercedes-Benz E63 S)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 22
            });

            // CarId = 23 (Mercedes-Benz S350d)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 23
            });

            // CarId = 24 (BMW M5 Competition)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 24
            });

            // CarId = 25 (BMW 730d)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 25
            });

            // CarId = 26 (Audi Q7)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 26
            });

            // CarId = 27 (Porsche Caynne)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 27
            });

            // CarId = 28 (Porsche Panamera)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 28
            });

            // CarId = 29 (Range Rover Sport)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 29
            });

            // CarId = 30 (Maserati Levante)
            carImages.Add(new CarImage()
            {
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 30
            });

            return carImages.ToArray();
        }

    }
}
