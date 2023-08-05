using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class SeedCarMake : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CarMakes",
                keyColumn: "Id",
                keyValue: 15);
        }
    }
}
