using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class colorFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The car's advanced technology includes a user-friendly 9.3-inch touchscreen with the Easy Link system. It seamlessly integrates with Android Auto and Apple CarPlay, allowing you to access your favorite apps and stay connected on the go. The navigation system, powered by Google Maps and TomTom, ensures you'll never lose your way.Enjoy a personalized driving experience with the customizable instrument cluster, which utilizes a TFT LCD display. The redesigned, compact steering wheel adds a touch of modernity to the cabin.Renault Clio comes equipped with an array of impressive features. The electric parking brake enhances convenience, while the wireless smartphone charger keeps your device powered up without messy cables. The hands-free parking feature takes the stress out of parking in tight spots.");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Hex",
                value: "#B30000");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Hex",
                value: "#FF9900");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Hex",
                value: "#008000");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The car's advanced technology includes a user-friendly 9.3-inch touchscreen with the Easy Link system. It seamlessly integrates with Android Auto and Apple CarPlay, allowing you to access your favorite apps and stay connected on the go. The navigation system, powered by Google Maps and TomTom, ensures you'll never lose your way. Enjoy a personalized driving experience with the customizable instrument cluster, which utilizes a TFT LCD display. The redesigned, compact steering wheel adds a touch of modernity to the cabin. Renault Clio comes equipped with an array of impressive features. The electric parking brake enhances convenience, while the wireless smartphone charger keeps your device powered up without messy cables. The hands-free parking feature takes the stress out of parking in tight spots.");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 6,
                column: "Hex",
                value: "B30000");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 7,
                column: "Hex",
                value: "FF9900");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 8,
                column: "Hex",
                value: "008000");
        }
    }
}
