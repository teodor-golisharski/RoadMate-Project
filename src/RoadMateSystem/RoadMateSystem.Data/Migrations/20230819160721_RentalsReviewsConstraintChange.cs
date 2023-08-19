using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class RentalsReviewsConstraintChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 16, 7, 21, 341, DateTimeKind.Utc).AddTicks(3584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 13, 19, 50, 271, DateTimeKind.Utc).AddTicks(4996));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Rentals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 19, 13, 19, 50, 271, DateTimeKind.Utc).AddTicks(4996),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 8, 19, 16, 7, 21, 341, DateTimeKind.Utc).AddTicks(3584));
        }
    }
}
