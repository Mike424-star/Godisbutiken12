using Microsoft.EntityFrameworkCore.Migrations;

namespace Godisbutiken12.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(nullable: true),
                    GodisID = table.Column<int>(nullable: true),
                    Amount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Godisar_GodisID",
                        column: x => x.GodisID,
                        principalTable: "Godisar",
                        principalColumn: "GodisID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "\\images\\thumbnails\\Thumbnailsoftcandy.jpg", "\\images\\Softcandy.jpg", true });

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "\\images\\thumbnails\\Hardcandythumbnail.jpg", "\\images\\Hardcandybild.jpg", true });

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "\\images\\thumbnails\\fruitcandythumbnail.jpg", "\\images\\fruitcandy.jpg", true });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_GodisID",
                table: "ShoppingCartItems",
                column: "GodisID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "~\\images\\thumbnail\\Thumbnail soft candy.jpg", "~\\images\\Soft candy.jpg", false });

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "~\\images\\thumbnail\\Hardcandybild.jpg", "~\\images\\Hardcandybild.jpg", false });

            migrationBuilder.UpdateData(
                table: "Godisar",
                keyColumn: "GodisID",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl", "IsOnSale" },
                values: new object[] { "~\\images\\thumbnail\\Hardcandybild.jpg", "~\\images\\fruitcandy.jpg", false });
        }
    }
}
