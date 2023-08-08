namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;
    using System.Reflection.Emit;

    public class CarImageEntityConfiguration : IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder.HasData(GenerateCarImages());
        }

        private CarImage[] GenerateCarImages()
        {
            ICollection<CarImage> carImages = new HashSet<CarImage>();

            // CarId = 1 (Renault Clio)
            carImages.Add(new CarImage()
            {
                Id = 1,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 2,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 3,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 4,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 5,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 6,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 1
            });
            carImages.Add(new CarImage()
            {
                Id = 7,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 1
            });

            // CarId = 2 (Dacia Duster)
            carImages.Add(new CarImage()
            {
                Id = 8,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                Id = 9,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                Id = 10,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                Id = 11,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                Id = 12,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 2
            });
            carImages.Add(new CarImage()
            {
                Id = 13,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 2
            });

            // CarId = 3 (Ford Fiesta)
            carImages.Add(new CarImage()
            {
                Id = 14,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 15,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 16,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 17,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 18,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 19,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 20,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 3
            });
            carImages.Add(new CarImage()
            {
                Id = 21,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 3
            });

            // CarId = 4 (Honda Jazz)
            carImages.Add(new CarImage()
            {
                Id = 22,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 23,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 24,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 25,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 26,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 27,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 28,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 29,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 4
            });
            carImages.Add(new CarImage()
            {
                Id = 30,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 4
            });

            // CarId = 5 (Peugeot 308)
            carImages.Add(new CarImage()
            {
                Id = 31,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 32,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 33,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 34,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 35,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 36,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 37,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 38,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 5
            });
            carImages.Add(new CarImage()
            {
                Id = 39,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 5
            });

            // CarId = 6 (Skoda Fabia)
            carImages.Add(new CarImage()
            {
                Id = 40,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                Id = 41,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                Id = 42,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                Id = 43,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                Id = 44,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 6
            });
            carImages.Add(new CarImage()
            {
                Id = 45,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 6
            });

            // CarId = 7 (Volkswagen Golf)
            carImages.Add(new CarImage()
            {
                Id = 46,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                Id = 47,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                Id = 48,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                Id = 49,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                Id = 50,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 7
            });
            carImages.Add(new CarImage()
            {
                Id = 51,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 7
            });

            // CarId = 8 (Dacia Spring)
            carImages.Add(new CarImage()
            {
                Id = 52,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                Id = 53,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                Id = 54,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                Id = 55,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 8
            });
            carImages.Add(new CarImage()
            {
                Id = 56,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 8
            });

            // CarId = 9 (Volkswagen T-Cross)
            carImages.Add(new CarImage()
            {
                Id = 57,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 58,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 59,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 60,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 61,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 62,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 9
            });
            carImages.Add(new CarImage()
            {
                Id = 63,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 9
            });

            // CarId = 10 (Toyota Corolla)
            carImages.Add(new CarImage()
            {
                Id = 64,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 65,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 66,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 67,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 68,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 69,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 10
            });
            carImages.Add(new CarImage()
            {
                Id = 70,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 10
            });

            // CarId = 11 (Skoda Octavia)
            carImages.Add(new CarImage()
            {
                Id = 71,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 72,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 73,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 74,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 75,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 76,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 77,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 78,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 11
            });
            carImages.Add(new CarImage()
            {
                Id = 79,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 11
            });

            // CarId = 12 (Skoda Superb)
            carImages.Add(new CarImage()
            {
                Id = 80,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 81,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 82,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 83,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 84,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 85,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 86,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 87,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 88,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 12
            });
            carImages.Add(new CarImage()
            {
                Id = 89,
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 12
            });

            // CarId = 13 (Volkswagen Passat)
            carImages.Add(new CarImage()
            {
                Id = 90,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 91,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 92,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 93,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 94,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 95,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 13
            });
            carImages.Add(new CarImage()
            {
                Id = 96,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 13
            });

            // CarId = 14 (Volkswagen Touareg)
            carImages.Add(new CarImage()
            {
                Id = 97,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 98,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 99,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 100,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 101,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 102,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 14
            });
            carImages.Add(new CarImage()
            {
                Id = 103,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 14
            });

            // CarId = 15 (Peugeot 508)
            carImages.Add(new CarImage()
            {
                Id = 104,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 105,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 106,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 107,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 108,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 109,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 110,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 111,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 15
            });
            carImages.Add(new CarImage()
            {
                Id = 112,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 15
            });

            // CarId = 16 (Peugeot 3008)
            carImages.Add(new CarImage()
            {
                Id = 113,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 114,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 115,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 116,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 117,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 118,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 119,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 16
            });
            carImages.Add(new CarImage()
            {
                Id = 120,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 16
            });

            // CarId = 17 (Mazda 6)
            carImages.Add(new CarImage()
            {
                Id = 121,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                Id = 122,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                Id = 123,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                Id = 124,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                Id = 125,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 17
            });
            carImages.Add(new CarImage()
            {
                Id = 126,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 17
            });

            // CarId = 18 (Mazda CX-5)
            carImages.Add(new CarImage()
            {
                Id = 127,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 128,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 129,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 130,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 131,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 132,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 133,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 134,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 18
            });
            carImages.Add(new CarImage()
            {
                Id = 135,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 18
            });

            // CarId = 19 (BMW 120d)
            carImages.Add(new CarImage()
            {
                Id = 136,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 137,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 138,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 139,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 140,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 141,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 142,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 143,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 19
            });
            carImages.Add(new CarImage()
            {
                Id = 144,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 19
            });

            // CarId = 20 (Audi A4 Allroad)
            carImages.Add(new CarImage()
            {
                Id = 145,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 146,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 147,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 148,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 149,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 150,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 151,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 152,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 20
            });
            carImages.Add(new CarImage()
            {
                Id = 153,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 20
            });

            // CarId = 21 (Mercedes-Benz GT63 S)
            carImages.Add(new CarImage()
            {
                Id = 154,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 155,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 156,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 157,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 158,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 159,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 160,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 21
            });
            carImages.Add(new CarImage()
            {
                Id = 161,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 21
            });

            // CarId = 22 (Mercedes-Benz E63 S)
            carImages.Add(new CarImage()
            {
                Id = 162,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 163,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 164,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 165,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 166,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 167,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 168,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 169,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 22
            });
            carImages.Add(new CarImage()
            {
                Id = 170,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 22
            });

            // CarId = 23 (Mercedes-Benz S350d)
            carImages.Add(new CarImage()
            {
                Id = 171,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 172,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 173,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 174,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 175,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 176,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 177,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 178,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 179,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 23
            });
            carImages.Add(new CarImage()
            {
                Id = 180,
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 23
            });

            // CarId = 24 (BMW M5 Competition)
            carImages.Add(new CarImage()
            {
                Id = 181,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 182,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 183,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 184,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 185,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 186,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 24
            });
            carImages.Add(new CarImage()
            {
                Id = 187,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 24
            });

            // CarId = 25 (BMW 730d)
            carImages.Add(new CarImage()
            {
                Id = 188,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 189,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 190,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 191,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 192,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 193,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 194,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 195,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 25
            });
            carImages.Add(new CarImage()
            {
                Id = 196,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 25
            });

            // CarId = 26 (Audi Q7)
            carImages.Add(new CarImage()
            {
                Id = 197,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 198,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 199,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 200,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 201,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 202,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 203,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 26
            });
            carImages.Add(new CarImage()
            {
                Id = 204,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 26
            });

            // CarId = 27 (Porsche Caynne)
            carImages.Add(new CarImage()
            {
                Id = 205,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 206,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 207,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 208,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 209,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 210,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 211,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 212,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 27
            });
            carImages.Add(new CarImage()
            {
                Id = 213,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 27
            });

            // CarId = 28 (Porsche Panamera)
            carImages.Add(new CarImage()
            {
                Id = 214,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 215,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 216,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 217,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 218,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 219,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 220,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 221,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 222,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 28
            });
            carImages.Add(new CarImage()
            {
                Id = 223,
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 28
            });

            // CarId = 29 (Range Rover Sport)
            carImages.Add(new CarImage()
            {
                Id = 224,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 225,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 226,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 227,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 228,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 229,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 29
            });
            carImages.Add(new CarImage()
            {
                Id = 230,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 29
            });

            // CarId = 30 (Maserati Levante)
            carImages.Add(new CarImage()
            {
                Id = 231,
                FileName = "Photo1",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 232,
                FileName = "Photo2",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 233,
                FileName = "Photo3",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 234,
                FileName = "Photo4",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 235,
                FileName = "Photo5",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 236,
                FileName = "Photo6",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 237,
                FileName = "Photo7",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 238,
                FileName = "Photo8",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 239,
                FileName = "Photo9",
                FileExtension = ".jpeg",
                CarId = 30
            });
            carImages.Add(new CarImage()
            {
                Id = 240,
                FileName = "Photo10",
                FileExtension = ".jpeg",
                CarId = 30
            });

            return carImages.ToArray();
        }

    }
}
