namespace RoadMateSystem.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using RoadMateSystem.Data.Models.Car;
    using System.Reflection.Emit;

    public class CarEntityConfigurations : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                .HasOne(c => c.Color)
                .WithMany(cc => cc.Cars)
                .HasForeignKey(c => c.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.CarMake)
                .WithMany(cc => cc.Cars)
                .HasForeignKey(c => c.CarMakeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(c => c.ThumbnailImage)
                .WithOne(cc => cc.Car)
                .HasForeignKey<Car>(c => c.ThumbnailImageId)
                .HasConstraintName("FK_Cars_CarImages_ThumbnailImageId")
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .Property(c => c.Drivetrain)
                .HasConversion<string>();

            builder
                .Property(c => c.Fuel)
                .HasConversion<string>();

            builder
                .Property(c => c.Type)
                .HasConversion<string>();

            builder
                .Property(c => c.Transmission)
                .HasConversion<string>();

            builder.HasData(this.GenerateCars());
        }

        private Car[] GenerateCars()
        {
            ICollection<Car> cars = new HashSet<Car>();

            // Renault Clio
            Car car;
            car = new Car()
            {
                Id = 1,
                CarMakeId = 1,
                Model = "Clio",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 4,
                Horsepower = 140,
                EngineCapacity = 1598,
                Seats = 5,
                Doors = 5,
                Description = "The car's advanced technology includes a user-friendly 9.3-inch touchscreen with the Easy Link system. It seamlessly integrates with Android Auto and Apple CarPlay, allowing you to access your favorite apps and stay connected on the go. The navigation system, powered by Google Maps and TomTom, ensures you'll never lose your way." +
                "Enjoy a personalized driving experience with the customizable instrument cluster, which utilizes a TFT LCD display. The redesigned, compact steering wheel adds a touch of modernity to the cabin." +
                "Renault Clio comes equipped with an array of impressive features. The electric parking brake enhances convenience, while the wireless smartphone charger keeps your device powered up without messy cables. The hands-free parking feature takes the stress out of parking in tight spots.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 52.99M,
                PricePerWeek = 319.99M,
                ThumbnailImageId = 1
            };
            cars.Add(car);

            // Dacia Duster
            car = new Car()
            {
                Id = 2,
                CarMakeId = 2,
                Model = "Duster",
                Type = CarType.SUV,
                Fuel = FuelType.Diesel,
                ColorId = 1,
                Horsepower = 115,
                EngineCapacity = 1461,
                Seats = 5,
                Doors = 5,
                Description = "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. " +
                "It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. " +
                "The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.",
                Transmission = Transmission.Manual,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 45.99M,
                PricePerWeek = 279.99M,
                ThumbnailImageId = 8
            };
            cars.Add(car);

            // Ford Fiesta
            car = new Car()
            {
                Id = 3,
                CarMakeId = 3,
                Model = "Fiesta",
                Type = CarType.Hatchback,
                Fuel = FuelType.Gasoline,
                ColorId = 2,
                Horsepower = 200,
                EngineCapacity = 1496,
                Seats = 5,
                Doors = 5,
                Description = "Ford Fiesta as standard is equipped with user-friendly infotainment system with a vibrant touchscreen display, supporting smartphone integration through Apple CarPlay and Android Auto. " +
                "Safety is not compromised, as the base model boasts advanced safety features like a rearview camera, traction control, and multiple airbags." +
                "Optional equipment includes a power sunroof, and advanced driver-assistance technologies like blind-spot monitoring and adaptive cruise control. " +
                "Furthermore, the optional infotainment package offers a premium sound system and built-in navigation for enhanced entertainment and seamless navigation.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 59.99M,
                PricePerWeek = 374.99M,
                ThumbnailImageId = 14
            };
            cars.Add(car);

            // Honda Jazz
            car = new Car()
            {
                Id = 4,
                CarMakeId = 4,
                Model = "Jazz",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 1,
                Horsepower = 122,
                EngineCapacity = 1498,
                Seats = 5,
                Doors = 5,
                Description = "The Honda Jazz is a versatile and practical subcompact car that offers a remarkable balance of efficiency and functionality. " +
                "The base model of the Honda Jazz comes generously equipped with modern features, including a user-friendly infotainment system with a touchscreen display, Bluetooth connectivity, and a rearview camera for added convenience and safety." +
                "Additionally, the car boasts a suite of advanced safety technologies, such as collision mitigation braking, lane-keeping assist, and adaptive cruise control.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 49.99M,
                PricePerWeek = 289.99M,
                ThumbnailImageId = 22
            };
            cars.Add(car);

            // Peugeot 308
            car = new Car()
            {
                Id = 5,
                CarMakeId = 5,
                Model = "308",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 1,
                Horsepower = 220,
                EngineCapacity = 1598,
                Seats = 5,
                Doors = 5,
                Description = "Peugeot 308 is equipped with LED headlights complemented by vertical LED daytime running lights. These headlights feature the Peugeot Matrix LED Technology on GT and GT Premium variants. " +
                "It is also equipped with the Drive Assist pack that adds adaptive cruise control with Stop and Go function, lane keeping assistance, semi-automatic lane change, anticipated speed recommendation, and curve speed adaptation. " +
                "Other features offered as standard or optional include long-range blind-spot monitoring, 360-degree surround-view parking assistance with four cameras, rear cross-traffic alert, heating for the windscreen and steering wheel, and an E-call+ emergency call function.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 61.99M,
                PricePerWeek = 384.99M,
                ThumbnailImageId = 31
            };
            cars.Add(car);

            // Skoda Fabia
            car = new Car()
            {
                Id = 6,
                CarMakeId = 6,
                Model = "Fabia",
                Type = CarType.Hatchback,
                Fuel = FuelType.Gasoline,
                ColorId = 7,
                Horsepower = 110,
                EngineCapacity = 999,
                Seats = 5,
                Doors = 5,
                Description = "The Skoda Fabia comes equipped with modern features, including a user-friendly infotainment system with a touchscreen display, smartphone connectivity via Android Auto and Apple CarPlay, and a rearview camera for easy parking maneuvers. " +
                "Optional features may include premium upholstery materials, a panoramic sunroof for a more airy cabin feel, and upgraded sound systems for enhanced entertainment. Advanced driver-assistance technologies, such as adaptive cruise control and parking sensors, are also available to provide added convenience and peace of mind.",
                Transmission = Transmission.Manual,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 48.99M,
                PricePerWeek = 279.99M,
                ThumbnailImageId = 40
            };
            cars.Add(car);

            // Volkswagen Golf
            car = new Car()
            {
                Id = 7,
                CarMakeId = 7,
                Model = "Golf",
                Type = CarType.Hatchback,
                Fuel = FuelType.Diesel,
                ColorId = 1,
                Horsepower = 150,
                EngineCapacity = 1968,
                Seats = 5,
                Doors = 5,
                Description = "The Golf VIII's interior receives a major overhaul with an entirely digital driver's display and digital control panel. " +
                "All Mk8s have advanced safety features available such as travel assist, Car2X, and an oncoming vehicle while braking function, the latter two of which are the first to be used on a production Volkswagen model",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 59.99M,
                PricePerWeek = 374.99M,
                ThumbnailImageId = 46
            };
            cars.Add(car);

            // Dacia Spring
            car = new Car()
            {
                Id = 8,
                CarMakeId = 2,
                Model = "Spring",
                Type = CarType.SUV,
                Fuel = FuelType.Electric,
                ColorId = 1,
                Horsepower = 65,
                Seats = 4,
                Doors = 5,
                Description = "Dacia Spring is the first electric model of the Romanian brand Dacia. " +
                "According to the WLTP City cycle, the Spring should do 305 km (189 miles) in town, while its combined WLTP range rating is 230 km (143 miles)." +
                "In terms of base equipment, the Dacia Spring boasts a simple yet functional interior with comfortable seating for passengers and a spacious cargo area. The infotainment system includes a 7-inch touchscreen display with smartphone integration, enabling seamless connectivity on the go. Safety features like ABS, electronic stability control, and multiple airbags come as standard, ensuring passenger safety.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 42.99M,
                PricePerWeek = 239.99M,
                ThumbnailImageId = 52
            };
            cars.Add(car);

            // Volkswagen T-Cross
            car = new Car()
            {
                Id = 9,
                CarMakeId = 7,
                Model = "T-Cross",
                Type = CarType.SUV,
                Fuel = FuelType.Gasoline,
                ColorId = 3,
                Horsepower = 110,
                EngineCapacity = 999,
                Seats = 5,
                Doors = 5,
                Description = "The Volkswagen T-Cross is a stylish and compact SUV that offers a perfect combination of versatility and modern design." +
                "The base model of the Volkswagen T-Cross comes equipped with a range of standard features, including a user-friendly infotainment system with a touchscreen display, Bluetooth connectivity, and USB ports for seamless smartphone integration. Safety is prioritized with advanced driver-assistance technologies, such as automatic emergency braking, lane-keeping assist, and adaptive cruise control.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 52.99M,
                PricePerWeek = 329.99M,
                ThumbnailImageId = 57
            };
            cars.Add(car);

            // Toyota Corolla
            car = new Car()
            {
                Id = 10,
                CarMakeId = 8,
                Model = "Corolla",
                Type = CarType.Hatchback,
                Fuel = FuelType.Hybrid,
                ColorId = 1,
                Horsepower = 196,
                EngineCapacity = 1987,
                Seats = 5,
                Doors = 5,
                Description = "The Toyota Corolla is an iconic and reliable compact sedan that has been a favorite among drivers worldwide for generations. As a practical and efficient daily driver, the Corolla offers a smooth and comfortable ride with its responsive 2.0 liter four-cylinder hybrid engine, delivering excellent fuel efficiency." +
                "All Corolla trim levels feature power windows and door locks, LED front headlamps and LED rear lamps, the Toyota STAR Safety System, a 4.2-inch multi-information display in the gauge cluster, and the Entune 3.0 touchscreen infotainment system with Apple CarPlay and Amazon Alexa integration (Android Auto was added for the 2021 model year).",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 61.99M,
                PricePerWeek = 379.99M,
                ThumbnailImageId = 64
            };
            cars.Add(car);

            // Skoda Octavia
            car = new Car()
            {
                Id = 11,
                CarMakeId = 6,
                Model = "Octavia",
                Type = CarType.Saloon,
                Fuel = FuelType.Gasoline,
                ColorId = 1,
                Horsepower = 245,
                EngineCapacity = 1968,
                Seats = 5,
                Doors = 5,
                Description = "The fourth generation Octavia features many new technologies. It is the first Škoda model to use a heads-up display. Other new technologies include two 10\" displays, wireless smartphone charging, up to 5 USB-C ports, a new Sound System by Canton, and the classic shifting stick for the automatic gearbox has been replaced with a small joystick. New safety features include taking control of steering in case of a possible accident, checking for oncoming vehicles when opening doors, and detection of the driver falling asleep or losing consciousness." +
                "The top model vRS includes sporty vRS seats, personalized vRS steering wheel, more aggresive looking exterior and powerful engines making the compact family saloon accelerates from 0 to 100 km/h in just 6.7 seconds.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 84.99M,
                PricePerWeek = 579.99M,
                ThumbnailImageId = 71
            };
            cars.Add(car);

            // Skoda Superb
            car = new Car()
            {
                Id = 12,
                CarMakeId = 6,
                Model = "Superb",
                Type = CarType.Saloon,
                Fuel = FuelType.Diesel,
                ColorId = 2,
                Horsepower = 200,
                EngineCapacity = 1968,
                Seats = 5,
                Doors = 5,
                Description = "The flagship of Skoda, the Superb is a large comfortable liftback providing even more luxurious experience than Skoda Octavia. " +
                "All Superbs come equipped with virtual cockpit, advanced driver-assistance features, powerful engines, spacious and comfort interior. " +
                "The top model Laurin & Klement adds to the car adaptive suspension, full-leather interior, upgraded sound system by Canton, matrix LED headlights, ambient lighting, ventilated seats and 3-zone climate control.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 94.99M,
                PricePerWeek = 619.99M,
                ThumbnailImageId = 80
            };
            cars.Add(car);

            // Volkswagen Passat
            car = new Car()
            {
                Id = 13,
                CarMakeId = 7,
                Model = "Passat",
                Type = CarType.Saloon,
                Fuel = FuelType.Diesel,
                ColorId = 2,
                Horsepower = 200,
                EngineCapacity = 1968,
                Seats = 5,
                Doors = 4,
                Description = "Passat is equipped with a great number of advanced driver-assistance systems, including a semi-automatic parking system, emergency driver assistant, which will automatically take control of the vehicle if the driver has suffered a medical emergency, autonomous cruise control system for highway speeds up to 210 km/h, a collision avoidance system with pedestrian monitoring and variable ratio steering marketed as \"progressive steering\" which will adjust the steering gear ratios in relation to the current speed." +
                "Volkswagen Passat also offers a spacious interior, a relativeley large boot compartment, R-line exterior and interior package and comfortable seats upholstered in a combination of leather and alcantara.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 89.99M,
                PricePerWeek = 574.99M,
                ThumbnailImageId = 90
            };
            cars.Add(car);

            // Volkswagen Touareg
            car = new Car()
            {
                Id = 14,
                CarMakeId = 7,
                Model = "Touareg",
                Type = CarType.SUV,
                Fuel = FuelType.Diesel,
                ColorId = 2,
                Horsepower = 262,
                EngineCapacity = 2967,
                Seats = 5,
                Doors = 5,
                Description = "The Volkswagen Touareg II may have a slightly outdated appearance, but don't let its looks deceive you. This large SUV stands as the premium model in the current brand lineup. Under the hood, the Touareg II is equipped with a robust 3.0 V6 turbo diesel engine, producing an impressive 262 horsepower, and granting this 2.3-ton vehicle the power to reign supreme on the road." +
                "The Touareg boasts exceptional ride comfort, thanks to highly noise-insulated cabin and the adaptive air suspension, providing a serene driving experience. Inside, the spacious and comfortable interior is luxuriously upholstered with leather and features 3-zone climate control, a panoramic sunroof, and more, ensuring an opulent journey." +
                "When it comes to technology, this SUV is by no means inferior to newer models, boasting advanced features like adaptive cruise control, blind-spot assist, reverse-parking assist, and 360-view cameras, providing both convenience and safety.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 94.99M,
                PricePerWeek = 619.99M,
                ThumbnailImageId = 97
            };
            cars.Add(car);

            // Peugeot 508
            car = new Car()
            {
                Id = 15,
                CarMakeId = 5,
                Model = "508",
                Type = CarType.Saloon,
                Fuel = FuelType.Diesel,
                ColorId = 2,
                Horsepower = 180,
                EngineCapacity = 1997,
                Seats = 5,
                Doors = 4,
                Description = "The Peugeot 508 is a sophisticated and stylish mid-size sedan that exudes elegance and performance. In its base model, the 508 comes equipped with a range of standard features to enhance the driving experience. " +
                "It boasts a user-friendly infotainment system with a large touchscreen display, offering seamless smartphone integration through Apple CarPlay and Android Auto. " +
                "Safety is prioritized with standard driver-assistance technologies like automatic emergency braking, lane-keeping assist, and blind-spot monitoring.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 79.99M,
                PricePerWeek = 519.99M,
                ThumbnailImageId = 104
            };
            cars.Add(car);

            // Peugeot 3008
            car = new Car()
            {
                Id = 16,
                CarMakeId = 5,
                Model = "3008",
                Type = CarType.SUV,
                Fuel = FuelType.Hybrid,
                ColorId = 2,
                Horsepower = 225,
                EngineCapacity = 1598,
                Seats = 5,
                Doors = 5,
                Description = "Peugeot 3008 features Peugeot's new iCockpit, which is an improved design compared to the current iCockpit featured in the Peugeot 208, Peugeot 2008 and Peugeot 308. " +
                "Features include an eight inch touch screen to the centre console, a 12.3 inch customisable heads up display, and the small style steering wheel, which has become standard in all current models of Peugeot." +
                "Peugeot 3008 is equipped with full-leather interior, matrix LED headlights, all driver assistants and panoramic sunroof.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 79.99M,
                PricePerWeek = 529.99M,
                ThumbnailImageId = 113
            };
            cars.Add(car);

            // Mazda 6
            car = new Car()
            {
                Id = 17,
                CarMakeId = 9,
                Model = "6",
                Type = CarType.Estate,
                Fuel = FuelType.Diesel,
                ColorId = 6,
                Horsepower = 184,
                EngineCapacity = 2191,
                Seats = 5,
                Doors = 5,
                Description = "The Mazda 6 Estate 2022 is a versatile and stylish midsize wagon that combines practicality with Mazda's signature driving dynamics. In its base model, the Mazda 6 Estate offers a comprehensive set of standard features to enhance the driving experience. The spacious interior is crafted with premium materials, and the infotainment system features an intuitive 8-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto." +
                "Safety is a top priority, as the Mazda 6 Estate comes equipped with standard driver-assistance technologies, including automatic emergency braking, lane-keeping assist, and adaptive cruise control, ensuring a safe and confident journey.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.FWD,
                PricePerDay = 79.99M,
                PricePerWeek = 529.99M,
                ThumbnailImageId = 121
            };
            cars.Add(car);

            // Mazda CX-5
            car = new Car()
            {
                Id = 18,
                CarMakeId = 9,
                Model = "CX-5",
                Type = CarType.SUV,
                Fuel = FuelType.Diesel,
                ColorId = 5,
                Horsepower = 184,
                EngineCapacity = 2191,
                Seats = 5,
                Doors = 5,
                Description = "The Mazda CX-5 2021 is a stylish and well-rounded compact SUV that combines performance with a touch of elegance. In its base model, the CX-5 offers a comprehensive set of standard features to elevate the driving experience. The interior is crafted with high-quality materials, and the infotainment system features a user-friendly 10.25-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto." +
                "Mazda CX-5 introduce premium amenities such as leather upholstery, a power liftgate for easy access to the cargo area, and an upgraded Bose sound system for a captivating audio experience." +
                "Additionally, optional technology packages include an advanced head-up display, a 360-degree view camera system for enhanced visibility, and an upgraded navigation system with real-time traffic updates, delivering added convenience and sophistication.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 79.99M,
                PricePerWeek = 529.99M,
                ThumbnailImageId = 127
            };
            cars.Add(car);

            // BMW 120d
            car = new Car()
            {
                Id = 19,
                CarMakeId = 10,
                Model = "120d",
                Type = CarType.Hatchback,
                Fuel = FuelType.Diesel,
                ColorId = 3,
                Horsepower = 190,
                EngineCapacity = 1995,
                Seats = 5,
                Doors = 5,
                Description = "The BMW 120d F40 is a sporty and dynamic compact luxury car that exudes performance and sophistication. In its base model, the BMW 120d comes equipped with a powerful 2.0-liter TwinPower Turbo diesel engine, providing impressive acceleration and fuel efficiency. " +
                "The interior features premium materials and the latest BMW iDrive infotainment system with an intuitive 8.8-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
                "BMW 120d is equipped with luxurious leather upholstery, a panoramic sunroof for an airy cabin ambiance, and a Harman Kardon premium sound system for an immersive audio experience." +
                "Optional technology package gives the car a head-up display for enhanced visibility, advanced parking assistance with a surround-view camera, and BMW's Live Cockpit Professional for an advanced digital instrument cluster.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 89.99M,
                PricePerWeek = 549.99M,
                ThumbnailImageId = 136
            };
            cars.Add(car);

            // Audi A4 Allroad
            car = new Car()
            {
                Id = 20,
                CarMakeId = 11,
                Model = "A4 Allroad",
                Type = CarType.Estate,
                Fuel = FuelType.Diesel,
                ColorId = 4,
                Horsepower = 286,
                EngineCapacity = 2967,
                Seats = 5,
                Doors = 5,
                Description = "The A4 Allroad 2022 is a versatile and adventurous luxury wagon that blends sophistication with off-road capabilities. In its base model, the A4 Allroad comes equipped with Audi's renowned quattro all-wheel-drive system, providing enhanced traction and stability in various driving conditions. " +
                "The interior features premium materials and the latest Audi MMI infotainment system with a user-friendly 10.1-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto." +
                "Safety is a top priority, as the A4 Allroad 2022 comes with standard driver-assistance technologies, including automatic emergency braking, lane departure warning, and adaptive cruise control, ensuring a safe and confident driving experience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 109.99M,
                PricePerWeek = 689.99M,
                ThumbnailImageId = 145
            };
            cars.Add(car);

            // Mercedes-Benz GT63 S
            car = new Car()
            {
                Id = 21,
                CarMakeId = 12,
                Model = "AMG GT63 S",
                Type = CarType.Coupe,
                Fuel = FuelType.Gasoline,
                ColorId = 2,
                Horsepower = 639,
                EngineCapacity = 3982,
                Seats = 4,
                Doors = 4,
                Description = "The GT 63 S is a high-performance luxury sports 4-door coupe that represents the pinnacle of Mercedes-AMG engineering and craftsmanship. It is a better equipped variant of the GT 4-Door and features the AMG M177 4.0L twin-turbocharged V8 engine, which produces 430 kW (630 hp; 639 PS) and 900 N⋅m (664 lbf⋅ft). The GT 63S will reportedly accelerate from 0–100 km/h (0–62 mph) in 3.2 seconds and attain a top speed of 315 km/h (196 mph) as tested by the manufacturer. The GT 63 also has an optional selectable \"Drift Mode\" which directs power solely to the rear wheels." +
                "Some of the features of this exclusive car are Nappa leather upholstery, a panoramic sunroof, ambient lighting in 64 different colors and a Burmester high-end 3D surround sound system for an immersive audio experience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 249.99M,
                PricePerWeek = 1649.99M,
                ThumbnailImageId = 154
            };
            cars.Add(car);

            // Mercedes-Benz E63 S
            car = new Car()
            {
                Id = 22,
                CarMakeId = 12,
                Model = "E63 S",
                Type = CarType.Saloon,
                Fuel = FuelType.Gasoline,
                ColorId = 3,
                Horsepower = 612,
                EngineCapacity = 3982,
                Seats = 5,
                Doors = 4,
                Description = "The W213 AMG E63 S is a high-performance luxury sedan that embodies the perfect blend of power, sophistication, and cutting-edge technology. The car is powered by the AMG M177 twin-turbo 4.0-liter V8 engine, generating an astonishing 612 horsepower." +
                "The interior showcases luxurious materials and advanced features, including a widescreen digital instrument cluster, a 12.3-inch infotainment display with smartphone integration, fully automated heated and ventilated seats with 7 different massage options, and premium Nappa leather upholstery.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 229.99M,
                PricePerWeek = 1549.99M,
                ThumbnailImageId = 162
            };
            cars.Add(car);

            // Mercedes-Benz S350d
            car = new Car()
            {
                Id = 23,
                CarMakeId = 12,
                Model = "S350d",
                Type = CarType.Saloon,
                Fuel = FuelType.Diesel,
                ColorId = 2,
                Horsepower = 286,
                EngineCapacity = 2925,
                Seats = 5,
                Doors = 4,
                Description = "The W223 S-Class is the epitome of luxury and innovation, representing Mercedes-Benz's flagship sedan with a perfect fusion of opulence and cutting-edge technology. In its base model, the S-Class offers an unparalleled level of sophistication, featuring premium materials, handcrafted details, and the latest technology. " +
                "The interior boasts a widescreen digital dashboard with a 12.8-inch OLED infotainment display and MBUX voice-activated system, providing seamless smartphone integration and advanced driver-assistance features like adaptive cruise control and lane-keeping assist for a secure and effortless drive." +
                "The car is equipped with rear-seat entertainment screens, a virtual reality head-up display for enhanced visibility, and Magic Body Control for an advanced adaptive suspension system, ensuring an unrivaled level of comfort and handling.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 239.99M,
                PricePerWeek = 1599.99M,
                ThumbnailImageId = 171
            };
            cars.Add(car);

            // BMW M5 Competition
            car = new Car()
            {
                Id = 24,
                CarMakeId = 10,
                Model = "M5 Competition",
                Type = CarType.Saloon,
                Fuel = FuelType.Gasoline,
                ColorId = 4,
                Horsepower = 625,
                EngineCapacity = 4395,
                Seats = 5,
                Doors = 4,
                Description = "The BMW M5 Competition F90 is a high-performance sports sedan that exemplifies the perfect fusion of power and luxury. " +
                "In its base model, the M5 Competition is equipped with a potent 4.4-liter BMW M TwinPower Turbo V8 engine, producing an impressive 625 horsepower, resulting in breathtaking acceleration and dynamic driving capabilities. The interior exudes sophistication with premium materials, ergonomically designed seats, and advanced technology, including a 12.3-inch digital instrument cluster and a 10.25-inch infotainment display with seamless smartphone integration." +
                "The car is equipped with premium Merino leather upholstery, a panoramic sunroof for an enhanced cabin ambiance, and a Bowers & Wilkins Diamond Surround Sound System for an immersive audio experience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 229.99M,
                PricePerWeek = 1549.99M,
                ThumbnailImageId = 181
            };
            cars.Add(car);

            // BMW 730d
            car = new Car()
            {
                Id = 25,
                CarMakeId = 10,
                Model = "730d",
                Type = CarType.Saloon,
                Fuel = FuelType.Diesel,
                ColorId = 5,
                Horsepower = 286,
                EngineCapacity = 2993,
                Seats = 4,
                Doors = 4,
                Description = "The BMW 730d 2020 is a luxurious and sophisticated executive sedan that epitomizes the perfect blend of comfort, performance, and advanced technology. In its base model, the 730d comes equipped with a robust 3.0-liter six-cylinder diesel engine, offering an impressive balance of power and fuel efficiency. " +
                "The interior is exquisitely designed with premium materials, plush leather upholstery, and advanced features, including a 12.3-inch digital instrument cluster and a 10.25-inch infotainment display with smartphone integration." +
                "Optional equipment includes a rear-seat entertainment system for passengers' enjoyment, refrigerator in the back, gesture control for intuitive infotainment control, and BMW's Driving Assistance Professional package for an elevated level of safety and convenience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 229.99M,
                PricePerWeek = 1549.99M,
                ThumbnailImageId = 188
            };
            cars.Add(car);

            // Audi Q7
            car = new Car()
            {
                Id = 26,
                CarMakeId = 11,
                Model = "Q7",
                Type = CarType.SUV,
                Fuel = FuelType.Gasoline,
                ColorId = 2,
                Horsepower = 340,
                EngineCapacity = 2995,
                Seats = 7,
                Doors = 5,
                Description = "The Audi Q7 2022 is a stylish and versatile luxury SUV that exudes a perfect combination of performance and sophistication. In its base model, the Q7 offers a spacious and refined interior, featuring premium materials and advanced technology. The infotainment system includes a 10.1-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto, ensuring a connected and enjoyable driving experience." +
                "Our Audi Q7 is equipped with plush leather upholstery, a panoramic sunroof for an open and airy cabin ambiance, and a premium Bang & Olufsen 3D sound system for an immersive audio experience." +
                "Furthermore, optional technology package includes Audi's Virtual Cockpit for a customizable digital instrument cluster, a head-up display for enhanced visibility, and adaptive air suspension for a smooth and adjustable ride, ensuring an unmatched level of comfort and handling.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 189.99M,
                PricePerWeek = 1299.99M,
                ThumbnailImageId = 197
            };
            cars.Add(car);

            // Porsche Cayenne
            car = new Car()
            {
                Id = 27,
                CarMakeId = 13,
                Model = "Cayenne",
                Type = CarType.SUV,
                Fuel = FuelType.Hybrid,
                ColorId = 3,
                Horsepower = 680,
                EngineCapacity = 3996,
                Seats = 5,
                Doors = 5,
                Description = "The Porsche Cayenne Turbo S E-Hybrid 2022 is a remarkable and powerful luxury SUV that embodies the perfect fusion of performance and sustainability. In its base model, the Cayenne Turbo S E-Hybrid is equipped with a cutting-edge hybrid powertrain, combining a twin-turbocharged V8 engine with an electric motor, producing an astonishing 680 horsepower and delivering electrifying acceleration and efficiency. " +
                "The interior boasts premium materials and advanced technology, featuring a 12.3-inch touchscreen infotainment display, smartphone integration, and Porsche Communication Management (PCM) for seamless connectivity." +
                "Optional technology package includes Porsche InnoDrive with adaptive cruise control, Night Vision Assist for enhanced visibility in low-light conditions, and Porsche Dynamic Chassis Control for superior handling and agility.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 279.99M,
                PricePerWeek = 1699.99M,
                ThumbnailImageId = 205
            };
            cars.Add(car);

            // Porsche Panamera
            car = new Car()
            {
                Id = 28,
                CarMakeId = 13,
                Model = "Panamera",
                Type = CarType.Saloon,
                Fuel = FuelType.Hybrid,
                ColorId = 5,
                Horsepower = 560,
                EngineCapacity = 2894,
                Seats = 4,
                Doors = 5,
                Description = "The Porsche 4S E-Hybrid 2022 is a cutting-edge and high-performance plug-in hybrid that exemplifies the perfect blend of exhilarating power and sustainability. In its base model, the 4S E-Hybrid is equipped with a sophisticated hybrid powertrain, combining a twin-turbocharged V6 engine with an electric motor, producing an impressive 552 horsepower and offering thrilling acceleration and efficiency. " +
                "The interior features premium materials and advanced technology, including a 12.3-inch touchscreen infotainment display, smartphone integration, and Porsche Communication Management (PCM) for seamless connectivity." +
                "Optional equipment includes exclusive leather upholstery, a panoramic sunroof for an open and airy cabin ambiance, and a high-end Burmester sound system for an immersive audio experience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 269.99M,
                PricePerWeek = 1649.99M,
                ThumbnailImageId = 214
            };
            cars.Add(car);

            // Range Rover Sport
            car = new Car()
            {
                Id = 29,
                CarMakeId = 14,
                Model = "Sport",
                Type = CarType.SUV,
                Fuel = FuelType.Gasoline,
                ColorId = 2,
                Horsepower = 575,
                EngineCapacity = 5000,
                Seats = 5,
                Doors = 5,
                Description = "The Range Rover Sport SVR 5.0 is a breathtaking and performance-oriented luxury SUV that embodies the perfect combination of power and refinement. In its base model, the Range Rover Sport SVR is equipped with a robust 5.0-liter supercharged V8 engine, generating a jaw-dropping 575 horsepower, resulting in exhilarating acceleration and exceptional off-road capabilities. " +
                "The interior showcases premium materials and advanced features, including a Touch Pro Duo infotainment system with a 10-inch touchscreen display, smartphone integration, and a Meridian sound system for immersive audio quality." +
                "Optional equipment includes premium Windsor leather upholstery, a panoramic sunroof for an expansive cabin ambiance, and a rear-seat entertainment system for passengers' enjoyment.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 229.99M,
                PricePerWeek = 1499.99M,
                ThumbnailImageId = 224
            };
            cars.Add(car);

            // Maserati Levante
            car = new Car()
            {
                Id = 30,
                CarMakeId = 15,
                Model = "Levante",
                Type = CarType.SUV,
                Fuel = FuelType.Gasoline,
                ColorId = 4,
                Horsepower = 590,
                EngineCapacity = 3799,
                Seats = 5,
                Doors = 5,
                Description = "The Maserati Levante Trofeo is a high-performance luxury SUV that represents the pinnacle of Maserati's engineering and craftsmanship. In its base model, the Levante Trofeo comes equipped with a ferocious 3.8-liter twin-turbocharged V8 engine, producing a remarkable 580 horsepower, resulting in breathtaking acceleration and agile handling." +
                "The interior is a testament to opulence with premium leather upholstery and advanced technology, featuring an 8.4-inch touchscreen infotainment display with smartphone integration and a Harman Kardon sound system for a captivating audio experience." +
                "It is equipped with exclusive Pieno Fiore leather upholstery, a panoramic sunroof for an expansive cabin ambiance, and a high-end Bowers & Wilkins Diamond Surround Sound System for an unparalleled audio experience.",
                Transmission = Transmission.Automatic,
                Drivetrain = Drivetrain.AWD,
                PricePerDay = 229.99M,
                PricePerWeek = 1499.99M,
                ThumbnailImageId = 231
            };
            cars.Add(car);

            return cars.ToArray();
        }
    }
}
