using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class InitializeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarMakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Hex = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileExtension = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarMakeId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Horsepower = table.Column<int>(type: "int", nullable: false),
                    EngineCapacity = table.Column<int>(type: "int", nullable: false),
                    Seats = table.Column<int>(type: "int", nullable: false),
                    Doors = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    Availability = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    Transmission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Drivetrain = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PricePerDay = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PricePerWeek = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ThumbnailImageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarImages_ThumbnailImageId",
                        column: x => x.ThumbnailImageId,
                        principalTable: "CarImages",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_CarMakes_CarMakeId",
                        column: x => x.CarMakeId,
                        principalTable: "CarMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.RentalId);
                    table.ForeignKey(
                        name: "FK_Rentals_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DatePosted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Reviews_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RentalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payment_Rentals_RentalId",
                        column: x => x.RentalId,
                        principalTable: "Rentals",
                        principalColumn: "RentalId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "Make" },
                values: new object[,]
                {
                    { 1, "Renault" },
                    { 2, "Dacia" },
                    { 3, "Ford" },
                    { 4, "Honda" },
                    { 5, "Peugeot" },
                    { 6, "Skoda" },
                    { 7, "Volkswagen" },
                    { 8, "Toyota" },
                    { 9, "Mazda" },
                    { 10, "BMW" },
                    { 11, "Audi" },
                    { 12, "Mercedes-Benz" },
                    { 13, "Porsche" },
                    { 14, "Range Rover" },
                    { 15, "Maserati" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Hex", "Name" },
                values: new object[,]
                {
                    { 1, "#FFFFFF", "White" },
                    { 2, "#000000", "Black" },
                    { 3, "#D9D9D9", "Silver" },
                    { 4, "#003399", "Blue" },
                    { 5, "#737373", "Grey" },
                    { 6, "B30000", "Red" },
                    { 7, "FF9900", "Orange" },
                    { 8, "008000", "Green" },
                    { 9, "#FFE800", "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Availability", "CarMakeId", "ColorId", "Description", "Doors", "Drivetrain", "EngineCapacity", "Fuel", "Horsepower", "Model", "PricePerDay", "PricePerWeek", "Seats", "ThumbnailImageId", "Transmission", "Type" },
                values: new object[,]
                {
                    { 1, true, 1, 4, "The car's advanced technology includes a user-friendly 9.3-inch touchscreen with the Easy Link system. It seamlessly integrates with Android Auto and Apple CarPlay, allowing you to access your favorite apps and stay connected on the go. The navigation system, powered by Google Maps and TomTom, ensures you'll never lose your way. Enjoy a personalized driving experience with the customizable instrument cluster, which utilizes a TFT LCD display. The redesigned, compact steering wheel adds a touch of modernity to the cabin. Renault Clio comes equipped with an array of impressive features. The electric parking brake enhances convenience, while the wireless smartphone charger keeps your device powered up without messy cables. The hands-free parking feature takes the stress out of parking in tight spots.", 5, "FWD", 1598, "Hybrid", 140, "Clio", 52.99m, 319.99m, 5, null, "Automatic", "Hatchback" },
                    { 2, true, 2, 1, "Dacia Duster features an electric power steering, a MultiView camera system consisting of four cameras, blind spot warning system, automatic climate control, keyless entry and ignition system, and daytime running lights. It also offers as standard Bluetooth, air conditioning, SatNav, rear parking sensors, rear camera, cruise control, six speed gearbox, alloy wheels, sports front seats. The ground clearance has been increased and a hill-start assist system is also offered, as well as hill descent control.", 5, "AWD", 1461, "Diesel", 115, "Duster", 45.99m, 279.99m, 5, null, "Manual", "SUV" },
                    { 3, true, 3, 2, "Ford Fiesta as standard is equipped with user-friendly infotainment system with a vibrant touchscreen display, supporting smartphone integration through Apple CarPlay and Android Auto. Safety is not compromised, as the base model boasts advanced safety features like a rearview camera, traction control, and multiple airbags.Optional equipment includes a power sunroof, and advanced driver-assistance technologies like blind-spot monitoring and adaptive cruise control. Furthermore, the optional infotainment package offers a premium sound system and built-in navigation for enhanced entertainment and seamless navigation.", 5, "FWD", 1496, "Gasoline", 200, "Fiesta", 59.99m, 374.99m, 5, null, "Automatic", "Hatchback" },
                    { 4, true, 4, 1, "The Honda Jazz is a versatile and practical subcompact car that offers a remarkable balance of efficiency and functionality. The base model of the Honda Jazz comes generously equipped with modern features, including a user-friendly infotainment system with a touchscreen display, Bluetooth connectivity, and a rearview camera for added convenience and safety.Additionally, the car boasts a suite of advanced safety technologies, such as collision mitigation braking, lane-keeping assist, and adaptive cruise control.", 5, "FWD", 1498, "Hybrid", 122, "Jazz", 49.99m, 289.99m, 5, null, "Automatic", "Hatchback" },
                    { 5, true, 5, 1, "Peugeot 308 is equipped with LED headlights complemented by vertical LED daytime running lights. These headlights feature the Peugeot Matrix LED Technology on GT and GT Premium variants. It is also equipped with the Drive Assist pack that adds adaptive cruise control with Stop and Go function, lane keeping assistance, semi-automatic lane change, anticipated speed recommendation, and curve speed adaptation. Other features offered as standard or optional include long-range blind-spot monitoring, 360-degree surround-view parking assistance with four cameras, rear cross-traffic alert, heating for the windscreen and steering wheel, and an E-call+ emergency call function.", 5, "FWD", 1598, "Hybrid", 220, "308", 61.99m, 384.99m, 5, null, "Automatic", "Hatchback" },
                    { 6, true, 6, 7, "The Skoda Fabia comes equipped with modern features, including a user-friendly infotainment system with a touchscreen display, smartphone connectivity via Android Auto and Apple CarPlay, and a rearview camera for easy parking maneuvers. Optional features may include premium upholstery materials, a panoramic sunroof for a more airy cabin feel, and upgraded sound systems for enhanced entertainment. Advanced driver-assistance technologies, such as adaptive cruise control and parking sensors, are also available to provide added convenience and peace of mind.", 5, "FWD", 999, "Gasoline", 110, "Fabia", 48.99m, 279.99m, 5, null, "Manual", "Hatchback" },
                    { 7, true, 7, 1, "The Golf VIII's interior receives a major overhaul with an entirely digital driver's display and digital control panel. All Mk8s have advanced safety features available such as travel assist, Car2X, and an oncoming vehicle while braking function, the latter two of which are the first to be used on a production Volkswagen model", 5, "FWD", 1968, "Diesel", 150, "Golf", 59.99m, 374.99m, 5, null, "Automatic", "Hatchback" },
                    { 8, true, 2, 1, "Dacia Spring is the first electric model of the Romanian brand Dacia. According to the WLTP City cycle, the Spring should do 305 km (189 miles) in town, while its combined WLTP range rating is 230 km (143 miles).In terms of base equipment, the Dacia Spring boasts a simple yet functional interior with comfortable seating for passengers and a spacious cargo area. The infotainment system includes a 7-inch touchscreen display with smartphone integration, enabling seamless connectivity on the go. Safety features like ABS, electronic stability control, and multiple airbags come as standard, ensuring passenger safety.", 5, "FWD", 0, "Electric", 65, "Spring", 42.99m, 239.99m, 4, null, "Automatic", "SUV" },
                    { 9, true, 7, 3, "The Volkswagen T-Cross is a stylish and compact SUV that offers a perfect combination of versatility and modern design.The base model of the Volkswagen T-Cross comes equipped with a range of standard features, including a user-friendly infotainment system with a touchscreen display, Bluetooth connectivity, and USB ports for seamless smartphone integration. Safety is prioritized with advanced driver-assistance technologies, such as automatic emergency braking, lane-keeping assist, and adaptive cruise control.", 5, "FWD", 999, "Gasoline", 110, "T-Cross", 52.99m, 329.99m, 5, null, "Automatic", "SUV" },
                    { 10, true, 8, 1, "The Toyota Corolla is an iconic and reliable compact sedan that has been a favorite among drivers worldwide for generations. As a practical and efficient daily driver, the Corolla offers a smooth and comfortable ride with its responsive 2.0 liter four-cylinder hybrid engine, delivering excellent fuel efficiency.All Corolla trim levels feature power windows and door locks, LED front headlamps and LED rear lamps, the Toyota STAR Safety System, a 4.2-inch multi-information display in the gauge cluster, and the Entune 3.0 touchscreen infotainment system with Apple CarPlay and Amazon Alexa integration (Android Auto was added for the 2021 model year).", 5, "FWD", 1987, "Hybrid", 196, "Corolla", 61.99m, 379.99m, 5, null, "Automatic", "Hatchback" },
                    { 11, true, 6, 1, "The fourth generation Octavia features many new technologies. It is the first Škoda model to use a heads-up display. Other new technologies include two 10\" displays, wireless smartphone charging, up to 5 USB-C ports, a new Sound System by Canton, and the classic shifting stick for the automatic gearbox has been replaced with a small joystick. New safety features include taking control of steering in case of a possible accident, checking for oncoming vehicles when opening doors, and detection of the driver falling asleep or losing consciousness.The top model vRS includes sporty vRS seats, personalized vRS steering wheel, more aggresive looking exterior and powerful engines making the compact family saloon accelerates from 0 to 100 km/h in just 6.7 seconds.", 5, "FWD", 1968, "Gasoline", 245, "Octavia", 84.99m, 579.99m, 5, null, "Automatic", "Saloon" },
                    { 12, true, 6, 2, "The flagship of Skoda, the Superb is a large comfortable liftback providing even more luxurious experience than Skoda Octavia. All Superbs come equipped with virtual cockpit, advanced driver-assistance features, powerful engines, spacious and comfort interior. The top model Laurin & Klement adds to the car adaptive suspension, full-leather interior, upgraded sound system by Canton, matrix LED headlights, ambient lighting, ventilated seats and 3-zone climate control.", 5, "AWD", 1968, "Diesel", 200, "Superb", 94.99m, 619.99m, 5, null, "Automatic", "Saloon" },
                    { 13, true, 7, 2, "Passat is equipped with a great number of advanced driver-assistance systems, including a semi-automatic parking system, emergency driver assistant, which will automatically take control of the vehicle if the driver has suffered a medical emergency, autonomous cruise control system for highway speeds up to 210 km/h, a collision avoidance system with pedestrian monitoring and variable ratio steering marketed as \"progressive steering\" which will adjust the steering gear ratios in relation to the current speed.Volkswagen Passat also offers a spacious interior, a relativeley large boot compartment, R-line exterior and interior package and comfortable seats upholstered in a combination of leather and alcantara.", 4, "AWD", 1968, "Diesel", 200, "Passat", 89.99m, 574.99m, 5, null, "Automatic", "Saloon" },
                    { 14, true, 7, 2, "The Volkswagen Touareg II may have a slightly outdated appearance, but don't let its looks deceive you. This large SUV stands as the premium model in the current brand lineup. Under the hood, the Touareg II is equipped with a robust 3.0 V6 turbo diesel engine, producing an impressive 262 horsepower, and granting this 2.3-ton vehicle the power to reign supreme on the road.The Touareg boasts exceptional ride comfort, thanks to highly noise-insulated cabin and the adaptive air suspension, providing a serene driving experience. Inside, the spacious and comfortable interior is luxuriously upholstered with leather and features 3-zone climate control, a panoramic sunroof, and more, ensuring an opulent journey.When it comes to technology, this SUV is by no means inferior to newer models, boasting advanced features like adaptive cruise control, blind-spot assist, reverse-parking assist, and 360-view cameras, providing both convenience and safety.", 5, "AWD", 2967, "Diesel", 262, "Touareg", 94.99m, 619.99m, 5, null, "Automatic", "SUV" },
                    { 15, true, 5, 2, "The Peugeot 508 is a sophisticated and stylish mid-size sedan that exudes elegance and performance. In its base model, the 508 comes equipped with a range of standard features to enhance the driving experience. It boasts a user-friendly infotainment system with a large touchscreen display, offering seamless smartphone integration through Apple CarPlay and Android Auto. Safety is prioritized with standard driver-assistance technologies like automatic emergency braking, lane-keeping assist, and blind-spot monitoring.", 4, "FWD", 1997, "Diesel", 180, "508", 79.99m, 519.99m, 5, null, "Automatic", "Saloon" },
                    { 16, true, 5, 2, "Peugeot 3008 features Peugeot's new iCockpit, which is an improved design compared to the current iCockpit featured in the Peugeot 208, Peugeot 2008 and Peugeot 308. Features include an eight inch touch screen to the centre console, a 12.3 inch customisable heads up display, and the small style steering wheel, which has become standard in all current models of Peugeot.Peugeot 3008 is equipped with full-leather interior, matrix LED headlights, all driver assistants and panoramic sunroof.", 5, "FWD", 1598, "Hybrid", 225, "3008", 79.99m, 529.99m, 5, null, "Automatic", "SUV" },
                    { 17, true, 9, 6, "The Mazda 6 Estate 2022 is a versatile and stylish midsize wagon that combines practicality with Mazda's signature driving dynamics. In its base model, the Mazda 6 Estate offers a comprehensive set of standard features to enhance the driving experience. The spacious interior is crafted with premium materials, and the infotainment system features an intuitive 8-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto.Safety is a top priority, as the Mazda 6 Estate comes equipped with standard driver-assistance technologies, including automatic emergency braking, lane-keeping assist, and adaptive cruise control, ensuring a safe and confident journey.", 5, "FWD", 2191, "Diesel", 184, "6", 79.99m, 529.99m, 5, null, "Automatic", "Estate" },
                    { 18, true, 9, 5, "The Mazda CX-5 2021 is a stylish and well-rounded compact SUV that combines performance with a touch of elegance. In its base model, the CX-5 offers a comprehensive set of standard features to elevate the driving experience. The interior is crafted with high-quality materials, and the infotainment system features a user-friendly 10.25-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto.Mazda CX-5 introduce premium amenities such as leather upholstery, a power liftgate for easy access to the cargo area, and an upgraded Bose sound system for a captivating audio experience.Additionally, optional technology packages include an advanced head-up display, a 360-degree view camera system for enhanced visibility, and an upgraded navigation system with real-time traffic updates, delivering added convenience and sophistication.", 5, "AWD", 2191, "Diesel", 184, "CX-5", 79.99m, 529.99m, 5, null, "Automatic", "SUV" },
                    { 19, true, 10, 3, "The BMW 120d F40 is a sporty and dynamic compact luxury car that exudes performance and sophistication. In its base model, the BMW 120d comes equipped with a powerful 2.0-liter TwinPower Turbo diesel engine, providing impressive acceleration and fuel efficiency. The interior features premium materials and the latest BMW iDrive infotainment system with an intuitive 8.8-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto.BMW 120d is equipped with luxurious leather upholstery, a panoramic sunroof for an airy cabin ambiance, and a Harman Kardon premium sound system for an immersive audio experience.Optional technology package gives the car a head-up display for enhanced visibility, advanced parking assistance with a surround-view camera, and BMW's Live Cockpit Professional for an advanced digital instrument cluster.", 5, "AWD", 1995, "Diesel", 190, "120d", 89.99m, 549.99m, 5, null, "Automatic", "Hatchback" },
                    { 20, true, 11, 4, "The A4 Allroad 2022 is a versatile and adventurous luxury wagon that blends sophistication with off-road capabilities. In its base model, the A4 Allroad comes equipped with Audi's renowned quattro all-wheel-drive system, providing enhanced traction and stability in various driving conditions. The interior features premium materials and the latest Audi MMI infotainment system with a user-friendly 10.1-inch touchscreen display, supporting seamless smartphone integration through Apple CarPlay and Android Auto.Safety is a top priority, as the A4 Allroad 2022 comes with standard driver-assistance technologies, including automatic emergency braking, lane departure warning, and adaptive cruise control, ensuring a safe and confident driving experience.", 5, "AWD", 2967, "Diesel", 286, "A4 Allroad", 109.99m, 689.99m, 5, null, "Automatic", "Estate" },
                    { 21, true, 12, 2, "The GT 63 S is a high-performance luxury sports 4-door coupe that represents the pinnacle of Mercedes-AMG engineering and craftsmanship. It is a better equipped variant of the GT 4-Door and features the AMG M177 4.0L twin-turbocharged V8 engine, which produces 430 kW (630 hp; 639 PS) and 900 N⋅m (664 lbf⋅ft). The GT 63S will reportedly accelerate from 0–100 km/h (0–62 mph) in 3.2 seconds and attain a top speed of 315 km/h (196 mph) as tested by the manufacturer. The GT 63 also has an optional selectable \"Drift Mode\" which directs power solely to the rear wheels.Some of the features of this exclusive car are Nappa leather upholstery, a panoramic sunroof, ambient lighting in 64 different colors and a Burmester high-end 3D surround sound system for an immersive audio experience.", 4, "AWD", 3982, "Gasoline", 639, "AMG GT63 S", 249.99m, 1649.99m, 4, null, "Automatic", "Coupe" },
                    { 22, true, 12, 3, "The W213 AMG E63 S is a high-performance luxury sedan that embodies the perfect blend of power, sophistication, and cutting-edge technology. The car is powered by the AMG M177 twin-turbo 4.0-liter V8 engine, generating an astonishing 612 horsepower.The interior showcases luxurious materials and advanced features, including a widescreen digital instrument cluster, a 12.3-inch infotainment display with smartphone integration, fully automated heated and ventilated seats with 7 different massage options, and premium Nappa leather upholstery.", 4, "AWD", 3982, "Gasoline", 612, "E63 S", 229.99m, 1549.99m, 5, null, "Automatic", "Saloon" },
                    { 23, true, 12, 2, "The W223 S-Class is the epitome of luxury and innovation, representing Mercedes-Benz's flagship sedan with a perfect fusion of opulence and cutting-edge technology. In its base model, the S-Class offers an unparalleled level of sophistication, featuring premium materials, handcrafted details, and the latest technology. The interior boasts a widescreen digital dashboard with a 12.8-inch OLED infotainment display and MBUX voice-activated system, providing seamless smartphone integration and advanced driver-assistance features like adaptive cruise control and lane-keeping assist for a secure and effortless drive.The car is equipped with rear-seat entertainment screens, a virtual reality head-up display for enhanced visibility, and Magic Body Control for an advanced adaptive suspension system, ensuring an unrivaled level of comfort and handling.", 4, "AWD", 2925, "Diesel", 286, "S350d", 239.99m, 1599.99m, 5, null, "Automatic", "Saloon" },
                    { 24, true, 10, 4, "The BMW M5 Competition F90 is a high-performance sports sedan that exemplifies the perfect fusion of power and luxury. In its base model, the M5 Competition is equipped with a potent 4.4-liter BMW M TwinPower Turbo V8 engine, producing an impressive 625 horsepower, resulting in breathtaking acceleration and dynamic driving capabilities. The interior exudes sophistication with premium materials, ergonomically designed seats, and advanced technology, including a 12.3-inch digital instrument cluster and a 10.25-inch infotainment display with seamless smartphone integration.The car is equipped with premium Merino leather upholstery, a panoramic sunroof for an enhanced cabin ambiance, and a Bowers & Wilkins Diamond Surround Sound System for an immersive audio experience.", 4, "AWD", 4395, "Gasoline", 625, "M5 Competition", 229.99m, 1549.99m, 5, null, "Automatic", "Saloon" },
                    { 25, true, 10, 5, "The BMW 730d 2020 is a luxurious and sophisticated executive sedan that epitomizes the perfect blend of comfort, performance, and advanced technology. In its base model, the 730d comes equipped with a robust 3.0-liter six-cylinder diesel engine, offering an impressive balance of power and fuel efficiency. The interior is exquisitely designed with premium materials, plush leather upholstery, and advanced features, including a 12.3-inch digital instrument cluster and a 10.25-inch infotainment display with smartphone integration.Optional equipment includes a rear-seat entertainment system for passengers' enjoyment, refrigerator in the back, gesture control for intuitive infotainment control, and BMW's Driving Assistance Professional package for an elevated level of safety and convenience.", 4, "AWD", 2993, "Diesel", 286, "730d", 229.99m, 1549.99m, 4, null, "Automatic", "Saloon" },
                    { 26, true, 11, 2, "The Audi Q7 2022 is a stylish and versatile luxury SUV that exudes a perfect combination of performance and sophistication. In its base model, the Q7 offers a spacious and refined interior, featuring premium materials and advanced technology. The infotainment system includes a 10.1-inch touchscreen display with seamless smartphone integration through Apple CarPlay and Android Auto, ensuring a connected and enjoyable driving experience.Our Audi Q7 is equipped with plush leather upholstery, a panoramic sunroof for an open and airy cabin ambiance, and a premium Bang & Olufsen 3D sound system for an immersive audio experience.Furthermore, optional technology package includes Audi's Virtual Cockpit for a customizable digital instrument cluster, a head-up display for enhanced visibility, and adaptive air suspension for a smooth and adjustable ride, ensuring an unmatched level of comfort and handling.", 5, "AWD", 2995, "Gasoline", 340, "Q7", 189.99m, 1299.99m, 7, null, "Automatic", "SUV" },
                    { 27, true, 13, 3, "The Porsche Cayenne Turbo S E-Hybrid 2022 is a remarkable and powerful luxury SUV that embodies the perfect fusion of performance and sustainability. In its base model, the Cayenne Turbo S E-Hybrid is equipped with a cutting-edge hybrid powertrain, combining a twin-turbocharged V8 engine with an electric motor, producing an astonishing 680 horsepower and delivering electrifying acceleration and efficiency. The interior boasts premium materials and advanced technology, featuring a 12.3-inch touchscreen infotainment display, smartphone integration, and Porsche Communication Management (PCM) for seamless connectivity.Optional technology package includes Porsche InnoDrive with adaptive cruise control, Night Vision Assist for enhanced visibility in low-light conditions, and Porsche Dynamic Chassis Control for superior handling and agility.", 5, "AWD", 3996, "Hybrid", 680, "Cayenne", 279.99m, 1699.99m, 5, null, "Automatic", "SUV" },
                    { 28, true, 13, 5, "The Porsche 4S E-Hybrid 2022 is a cutting-edge and high-performance plug-in hybrid that exemplifies the perfect blend of exhilarating power and sustainability. In its base model, the 4S E-Hybrid is equipped with a sophisticated hybrid powertrain, combining a twin-turbocharged V6 engine with an electric motor, producing an impressive 552 horsepower and offering thrilling acceleration and efficiency. The interior features premium materials and advanced technology, including a 12.3-inch touchscreen infotainment display, smartphone integration, and Porsche Communication Management (PCM) for seamless connectivity.Optional equipment includes exclusive leather upholstery, a panoramic sunroof for an open and airy cabin ambiance, and a high-end Burmester sound system for an immersive audio experience.", 5, "AWD", 2894, "Hybrid", 560, "Panamera", 269.99m, 1649.99m, 4, null, "Automatic", "Saloon" },
                    { 29, true, 14, 2, "The Range Rover Sport SVR 5.0 is a breathtaking and performance-oriented luxury SUV that embodies the perfect combination of power and refinement. In its base model, the Range Rover Sport SVR is equipped with a robust 5.0-liter supercharged V8 engine, generating a jaw-dropping 575 horsepower, resulting in exhilarating acceleration and exceptional off-road capabilities. The interior showcases premium materials and advanced features, including a Touch Pro Duo infotainment system with a 10-inch touchscreen display, smartphone integration, and a Meridian sound system for immersive audio quality.Optional equipment includes premium Windsor leather upholstery, a panoramic sunroof for an expansive cabin ambiance, and a rear-seat entertainment system for passengers' enjoyment.", 5, "AWD", 5000, "Gasoline", 575, "Sport", 229.99m, 1499.99m, 5, null, "Automatic", "SUV" },
                    { 30, true, 15, 4, "The Maserati Levante Trofeo is a high-performance luxury SUV that represents the pinnacle of Maserati's engineering and craftsmanship. In its base model, the Levante Trofeo comes equipped with a ferocious 3.8-liter twin-turbocharged V8 engine, producing a remarkable 580 horsepower, resulting in breathtaking acceleration and agile handling.The interior is a testament to opulence with premium leather upholstery and advanced technology, featuring an 8.4-inch touchscreen infotainment display with smartphone integration and a Harman Kardon sound system for a captivating audio experience.It is equipped with exclusive Pieno Fiore leather upholstery, a panoramic sunroof for an expansive cabin ambiance, and a high-end Bowers & Wilkins Diamond Surround Sound System for an unparalleled audio experience.", 5, "AWD", 3799, "Gasoline", 590, "Levante", 229.99m, 1499.99m, 5, null, "Automatic", "SUV" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 1, null, 1, ".jpeg", "Photo1" },
                    { 2, null, 1, ".jpeg", "Photo2" },
                    { 3, null, 1, ".jpeg", "Photo3" },
                    { 4, null, 1, ".jpeg", "Photo4" },
                    { 5, null, 1, ".jpeg", "Photo5" },
                    { 6, null, 1, ".jpeg", "Photo6" },
                    { 7, null, 1, ".jpeg", "Photo7" },
                    { 8, null, 2, ".jpeg", "Photo1" },
                    { 9, null, 2, ".jpeg", "Photo2" },
                    { 10, null, 2, ".jpeg", "Photo3" },
                    { 11, null, 2, ".jpeg", "Photo4" },
                    { 12, null, 2, ".jpeg", "Photo5" },
                    { 13, null, 2, ".jpeg", "Photo6" },
                    { 14, null, 3, ".jpeg", "Photo1" },
                    { 15, null, 3, ".jpeg", "Photo2" },
                    { 16, null, 3, ".jpeg", "Photo3" },
                    { 17, null, 3, ".jpeg", "Photo4" },
                    { 18, null, 3, ".jpeg", "Photo5" },
                    { 19, null, 3, ".jpeg", "Photo6" },
                    { 20, null, 3, ".jpeg", "Photo7" },
                    { 21, null, 3, ".jpeg", "Photo8" },
                    { 22, null, 4, ".jpeg", "Photo1" },
                    { 23, null, 4, ".jpeg", "Photo2" },
                    { 24, null, 4, ".jpeg", "Photo3" },
                    { 25, null, 4, ".jpeg", "Photo4" },
                    { 26, null, 4, ".jpeg", "Photo5" },
                    { 27, null, 4, ".jpeg", "Photo6" },
                    { 28, null, 4, ".jpeg", "Photo7" },
                    { 29, null, 4, ".jpeg", "Photo8" },
                    { 30, null, 4, ".jpeg", "Photo9" },
                    { 31, null, 5, ".jpeg", "Photo1" },
                    { 32, null, 5, ".jpeg", "Photo2" },
                    { 33, null, 5, ".jpeg", "Photo3" },
                    { 34, null, 5, ".jpeg", "Photo4" },
                    { 35, null, 5, ".jpeg", "Photo5" },
                    { 36, null, 5, ".jpeg", "Photo6" },
                    { 37, null, 5, ".jpeg", "Photo7" },
                    { 38, null, 5, ".jpeg", "Photo8" },
                    { 39, null, 5, ".jpeg", "Photo9" },
                    { 40, null, 6, ".jpeg", "Photo1" },
                    { 41, null, 6, ".jpeg", "Photo2" },
                    { 42, null, 6, ".jpeg", "Photo3" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 43, null, 6, ".jpeg", "Photo4" },
                    { 44, null, 6, ".jpeg", "Photo5" },
                    { 45, null, 6, ".jpeg", "Photo6" },
                    { 46, null, 7, ".jpeg", "Photo1" },
                    { 47, null, 7, ".jpeg", "Photo2" },
                    { 48, null, 7, ".jpeg", "Photo3" },
                    { 49, null, 7, ".jpeg", "Photo4" },
                    { 50, null, 7, ".jpeg", "Photo5" },
                    { 51, null, 7, ".jpeg", "Photo6" },
                    { 52, null, 8, ".jpeg", "Photo1" },
                    { 53, null, 8, ".jpeg", "Photo2" },
                    { 54, null, 8, ".jpeg", "Photo3" },
                    { 55, null, 8, ".jpeg", "Photo4" },
                    { 56, null, 8, ".jpeg", "Photo5" },
                    { 57, null, 9, ".jpeg", "Photo1" },
                    { 58, null, 9, ".jpeg", "Photo2" },
                    { 59, null, 9, ".jpeg", "Photo3" },
                    { 60, null, 9, ".jpeg", "Photo4" },
                    { 61, null, 9, ".jpeg", "Photo5" },
                    { 62, null, 9, ".jpeg", "Photo6" },
                    { 63, null, 9, ".jpeg", "Photo7" },
                    { 64, null, 10, ".jpeg", "Photo1" },
                    { 65, null, 10, ".jpeg", "Photo2" },
                    { 66, null, 10, ".jpeg", "Photo3" },
                    { 67, null, 10, ".jpeg", "Photo4" },
                    { 68, null, 10, ".jpeg", "Photo5" },
                    { 69, null, 10, ".jpeg", "Photo6" },
                    { 70, null, 10, ".jpeg", "Photo7" },
                    { 71, null, 11, ".jpeg", "Photo1" },
                    { 72, null, 11, ".jpeg", "Photo2" },
                    { 73, null, 11, ".jpeg", "Photo3" },
                    { 74, null, 11, ".jpeg", "Photo4" },
                    { 75, null, 11, ".jpeg", "Photo5" },
                    { 76, null, 11, ".jpeg", "Photo6" },
                    { 77, null, 11, ".jpeg", "Photo7" },
                    { 78, null, 11, ".jpeg", "Photo8" },
                    { 79, null, 11, ".jpeg", "Photo9" },
                    { 80, null, 12, ".jpeg", "Photo1" },
                    { 81, null, 12, ".jpeg", "Photo2" },
                    { 82, null, 12, ".jpeg", "Photo3" },
                    { 83, null, 12, ".jpeg", "Photo4" },
                    { 84, null, 12, ".jpeg", "Photo5" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 85, null, 12, ".jpeg", "Photo6" },
                    { 86, null, 12, ".jpeg", "Photo7" },
                    { 87, null, 12, ".jpeg", "Photo8" },
                    { 88, null, 12, ".jpeg", "Photo9" },
                    { 89, null, 12, ".jpeg", "Photo10" },
                    { 90, null, 13, ".jpeg", "Photo1" },
                    { 91, null, 13, ".jpeg", "Photo2" },
                    { 92, null, 13, ".jpeg", "Photo3" },
                    { 93, null, 13, ".jpeg", "Photo4" },
                    { 94, null, 13, ".jpeg", "Photo5" },
                    { 95, null, 13, ".jpeg", "Photo6" },
                    { 96, null, 13, ".jpeg", "Photo7" },
                    { 97, null, 14, ".jpeg", "Photo1" },
                    { 98, null, 14, ".jpeg", "Photo2" },
                    { 99, null, 14, ".jpeg", "Photo3" },
                    { 100, null, 14, ".jpeg", "Photo4" },
                    { 101, null, 14, ".jpeg", "Photo5" },
                    { 102, null, 14, ".jpeg", "Photo6" },
                    { 103, null, 14, ".jpeg", "Photo7" },
                    { 104, null, 15, ".jpeg", "Photo1" },
                    { 105, null, 15, ".jpeg", "Photo2" },
                    { 106, null, 15, ".jpeg", "Photo3" },
                    { 107, null, 15, ".jpeg", "Photo4" },
                    { 108, null, 15, ".jpeg", "Photo5" },
                    { 109, null, 15, ".jpeg", "Photo6" },
                    { 110, null, 15, ".jpeg", "Photo7" },
                    { 111, null, 15, ".jpeg", "Photo8" },
                    { 112, null, 15, ".jpeg", "Photo9" },
                    { 113, null, 16, ".jpeg", "Photo1" },
                    { 114, null, 16, ".jpeg", "Photo2" },
                    { 115, null, 16, ".jpeg", "Photo3" },
                    { 116, null, 16, ".jpeg", "Photo4" },
                    { 117, null, 16, ".jpeg", "Photo5" },
                    { 118, null, 16, ".jpeg", "Photo6" },
                    { 119, null, 16, ".jpeg", "Photo7" },
                    { 120, null, 16, ".jpeg", "Photo8" },
                    { 121, null, 17, ".jpeg", "Photo1" },
                    { 122, null, 17, ".jpeg", "Photo2" },
                    { 123, null, 17, ".jpeg", "Photo3" },
                    { 124, null, 17, ".jpeg", "Photo4" },
                    { 125, null, 17, ".jpeg", "Photo5" },
                    { 126, null, 17, ".jpeg", "Photo6" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 127, null, 18, ".jpeg", "Photo1" },
                    { 128, null, 18, ".jpeg", "Photo2" },
                    { 129, null, 18, ".jpeg", "Photo3" },
                    { 130, null, 18, ".jpeg", "Photo4" },
                    { 131, null, 18, ".jpeg", "Photo5" },
                    { 132, null, 18, ".jpeg", "Photo6" },
                    { 133, null, 18, ".jpeg", "Photo7" },
                    { 134, null, 18, ".jpeg", "Photo8" },
                    { 135, null, 18, ".jpeg", "Photo9" },
                    { 136, null, 19, ".jpeg", "Photo1" },
                    { 137, null, 19, ".jpeg", "Photo2" },
                    { 138, null, 19, ".jpeg", "Photo3" },
                    { 139, null, 19, ".jpeg", "Photo4" },
                    { 140, null, 19, ".jpeg", "Photo5" },
                    { 141, null, 19, ".jpeg", "Photo6" },
                    { 142, null, 19, ".jpeg", "Photo7" },
                    { 143, null, 19, ".jpeg", "Photo8" },
                    { 144, null, 19, ".jpeg", "Photo9" },
                    { 145, null, 20, ".jpeg", "Photo1" },
                    { 146, null, 20, ".jpeg", "Photo2" },
                    { 147, null, 20, ".jpeg", "Photo3" },
                    { 148, null, 20, ".jpeg", "Photo4" },
                    { 149, null, 20, ".jpeg", "Photo5" },
                    { 150, null, 20, ".jpeg", "Photo6" },
                    { 151, null, 20, ".jpeg", "Photo7" },
                    { 152, null, 20, ".jpeg", "Photo8" },
                    { 153, null, 20, ".jpeg", "Photo9" },
                    { 154, null, 21, ".jpeg", "Photo1" },
                    { 155, null, 21, ".jpeg", "Photo2" },
                    { 156, null, 21, ".jpeg", "Photo3" },
                    { 157, null, 21, ".jpeg", "Photo4" },
                    { 158, null, 21, ".jpeg", "Photo5" },
                    { 159, null, 21, ".jpeg", "Photo6" },
                    { 160, null, 21, ".jpeg", "Photo7" },
                    { 161, null, 21, ".jpeg", "Photo8" },
                    { 162, null, 22, ".jpeg", "Photo1" },
                    { 163, null, 22, ".jpeg", "Photo2" },
                    { 164, null, 22, ".jpeg", "Photo3" },
                    { 165, null, 22, ".jpeg", "Photo4" },
                    { 166, null, 22, ".jpeg", "Photo5" },
                    { 167, null, 22, ".jpeg", "Photo6" },
                    { 168, null, 22, ".jpeg", "Photo7" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 169, null, 22, ".jpeg", "Photo8" },
                    { 170, null, 22, ".jpeg", "Photo9" },
                    { 171, null, 23, ".jpeg", "Photo1" },
                    { 172, null, 23, ".jpeg", "Photo2" },
                    { 173, null, 23, ".jpeg", "Photo3" },
                    { 174, null, 23, ".jpeg", "Photo4" },
                    { 175, null, 23, ".jpeg", "Photo5" },
                    { 176, null, 23, ".jpeg", "Photo6" },
                    { 177, null, 23, ".jpeg", "Photo7" },
                    { 178, null, 23, ".jpeg", "Photo8" },
                    { 179, null, 23, ".jpeg", "Photo9" },
                    { 180, null, 23, ".jpeg", "Photo10" },
                    { 181, null, 24, ".jpeg", "Photo1" },
                    { 182, null, 24, ".jpeg", "Photo2" },
                    { 183, null, 24, ".jpeg", "Photo3" },
                    { 184, null, 24, ".jpeg", "Photo4" },
                    { 185, null, 24, ".jpeg", "Photo5" },
                    { 186, null, 24, ".jpeg", "Photo6" },
                    { 187, null, 24, ".jpeg", "Photo7" },
                    { 188, null, 25, ".jpeg", "Photo1" },
                    { 189, null, 25, ".jpeg", "Photo2" },
                    { 190, null, 25, ".jpeg", "Photo3" },
                    { 191, null, 25, ".jpeg", "Photo4" },
                    { 192, null, 25, ".jpeg", "Photo5" },
                    { 193, null, 25, ".jpeg", "Photo6" },
                    { 194, null, 25, ".jpeg", "Photo7" },
                    { 195, null, 25, ".jpeg", "Photo8" },
                    { 196, null, 25, ".jpeg", "Photo9" },
                    { 197, null, 26, ".jpeg", "Photo1" },
                    { 198, null, 26, ".jpeg", "Photo2" },
                    { 199, null, 26, ".jpeg", "Photo3" },
                    { 200, null, 26, ".jpeg", "Photo4" },
                    { 201, null, 26, ".jpeg", "Photo5" },
                    { 202, null, 26, ".jpeg", "Photo6" },
                    { 203, null, 26, ".jpeg", "Photo7" },
                    { 204, null, 26, ".jpeg", "Photo8" },
                    { 205, null, 27, ".jpeg", "Photo1" },
                    { 206, null, 27, ".jpeg", "Photo2" },
                    { 207, null, 27, ".jpeg", "Photo3" },
                    { 208, null, 27, ".jpeg", "Photo4" },
                    { 209, null, 27, ".jpeg", "Photo5" },
                    { 210, null, 27, ".jpeg", "Photo6" }
                });

            migrationBuilder.InsertData(
                table: "CarImages",
                columns: new[] { "Id", "Caption", "CarId", "FileExtension", "FileName" },
                values: new object[,]
                {
                    { 211, null, 27, ".jpeg", "Photo7" },
                    { 212, null, 27, ".jpeg", "Photo8" },
                    { 213, null, 27, ".jpeg", "Photo9" },
                    { 214, null, 28, ".jpeg", "Photo1" },
                    { 215, null, 28, ".jpeg", "Photo2" },
                    { 216, null, 28, ".jpeg", "Photo3" },
                    { 217, null, 28, ".jpeg", "Photo4" },
                    { 218, null, 28, ".jpeg", "Photo5" },
                    { 219, null, 28, ".jpeg", "Photo6" },
                    { 220, null, 28, ".jpeg", "Photo7" },
                    { 221, null, 28, ".jpeg", "Photo8" },
                    { 222, null, 28, ".jpeg", "Photo9" },
                    { 223, null, 28, ".jpeg", "Photo10" },
                    { 224, null, 29, ".jpeg", "Photo1" },
                    { 225, null, 29, ".jpeg", "Photo2" },
                    { 226, null, 29, ".jpeg", "Photo3" },
                    { 227, null, 29, ".jpeg", "Photo4" },
                    { 228, null, 29, ".jpeg", "Photo5" },
                    { 229, null, 29, ".jpeg", "Photo6" },
                    { 230, null, 29, ".jpeg", "Photo7" },
                    { 231, null, 30, ".jpeg", "Photo1" },
                    { 232, null, 30, ".jpeg", "Photo2" },
                    { 233, null, 30, ".jpeg", "Photo3" },
                    { 234, null, 30, ".jpeg", "Photo4" },
                    { 235, null, 30, ".jpeg", "Photo5" },
                    { 236, null, 30, ".jpeg", "Photo6" },
                    { 237, null, 30, ".jpeg", "Photo7" },
                    { 238, null, 30, ".jpeg", "Photo8" },
                    { 239, null, 30, ".jpeg", "Photo9" },
                    { 240, null, 30, ".jpeg", "Photo10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarMakeId",
                table: "Cars",
                column: "CarMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ThumbnailImageId",
                table: "Cars",
                column: "ThumbnailImageId",
                unique: true,
                filter: "[ThumbnailImageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_RentalId",
                table: "Payment",
                column: "RentalId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_UserId",
                table: "Rentals",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CarId",
                table: "Reviews",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "CarImages");

            migrationBuilder.DropTable(
                name: "CarMakes");

            migrationBuilder.DropTable(
                name: "Colors");
        }
    }
}
