using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class CreatedOnPropertyAddedToRental : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 11, 19, 17, 48, 929, DateTimeKind.Utc).AddTicks(6953));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Rentals");
        }
    }
}
