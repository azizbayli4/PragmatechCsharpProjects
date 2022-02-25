using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCsharp03.Migrations
{
    public partial class addeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 1, "on Jackets", "Get up to 30% off", "slide1.jpg", 199, "Winter Fashion Trends" });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "ClothType", "DisCount", "Image", "Price", "TrendWord" },
                values: new object[] { 2, "on Coat", "Get up to 20% off", "slide2.jpg", 300, "Season Fashion Trends" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sliders",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
