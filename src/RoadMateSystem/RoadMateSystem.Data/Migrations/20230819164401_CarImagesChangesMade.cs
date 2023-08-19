using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class CarImagesChangesMade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Caption",
                table: "CarImages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CarImages");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 16, 44, 0, 823, DateTimeKind.Utc).AddTicks(8557),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 16, 40, 58, 959, DateTimeKind.Utc).AddTicks(7119));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 16, 40, 58, 959, DateTimeKind.Utc).AddTicks(7119),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 16, 44, 0, 823, DateTimeKind.Utc).AddTicks(8557));

            migrationBuilder.AddColumn<string>(
                name: "Caption",
                table: "CarImages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CarImages",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
