using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RoadMateSystem.Data.Migrations
{
    public partial class InitializeDb_CarIdFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages");

            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_Cars_CarId1",
                table: "CarImages");

            migrationBuilder.DropIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages");

            migrationBuilder.DropIndex(
                name: "IX_CarImages_CarId1",
                table: "CarImages");

            migrationBuilder.DropColumn(
                name: "CarId1",
                table: "CarImages");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ThumbnailImageId",
                table: "Cars",
                column: "ThumbnailImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_CarImages_ThumbnailImageId",
                table: "Cars",
                column: "ThumbnailImageId",
                principalTable: "CarImages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_CarImages_ThumbnailImageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_ThumbnailImageId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages");

            migrationBuilder.AddColumn<int>(
                name: "CarId1",
                table: "CarImages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId",
                table: "CarImages",
                column: "CarId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarImages_CarId1",
                table: "CarImages",
                column: "CarId1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_Cars_CarId",
                table: "CarImages",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarImages_Cars_CarId1",
                table: "CarImages",
                column: "CarId1",
                principalTable: "Cars",
                principalColumn: "Id");
        }
    }
}
