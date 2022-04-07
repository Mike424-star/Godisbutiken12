using Microsoft.EntityFrameworkCore.Migrations;

namespace Godisbutiken12.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Soft Candy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "Hard Candy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Fruit Candy" });

            migrationBuilder.InsertData(
                table: "Godisar",
                columns: new[] { "GodisID", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 1, 1, "Bästa godis!", "~\\images\\thumbnail\\Thumbnail soft candy.jpg", "~\\images\\Soft candy.jpg", true, false, "Assorted Soft Candy", 5 });

            migrationBuilder.InsertData(
                table: "Godisar",
                columns: new[] { "GodisID", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 2, 2, "Bästa godis!", "~\\images\\thumbnail\\Hardcandybild.jpg", "~\\images\\Hardcandybild.jpg", true, false, "Assorted Hard Candy", 3 });

            migrationBuilder.InsertData(
                table: "Godisar",
                columns: new[] { "GodisID", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[] { 3, 3, "Bästa godis!", "~\\images\\thumbnail\\Hardcandybild.jpg", "~\\images\\fruitcandy.jpg", true, false, "Assorted Fruit Candy", 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
