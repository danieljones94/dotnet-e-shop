using Microsoft.EntityFrameworkCore.Migrations;

namespace e_shop.Migrations
{
    public partial class AddingShoppingCartItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SweetId = table.Column<int>(type: "int", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Sweets_SweetId",
                        column: x => x.SweetId,
                        principalTable: "Sweets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\chocolateSweets-small.jpg", "\\images\\chocolateSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\chocolateSweets2-small.jpg", "\\images\\chocolateSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\chocolateSweets3-small.jpg", "\\images\\chocolateSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\fruitSweets-small.jpg", "\\images\\fruitSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\fruitSweets2-small.jpg", "\\images\\fruitSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\fruitSweets3-small.jpg", "\\images\\fruitSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\gummySweets-small.jpg", "\\images\\gummySweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\gummySweets2-small.jpg", "\\images\\gummySweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\gummySweets3-small.jpg", "\\images\\gummySweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenSweets-small.jpg", "\\images\\halloweenSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenSweets2-small.jpg", "\\images\\halloweenSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\halloweenSweets3-small.jpg", "\\images\\halloweenSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\hardSweets-small.jpg", "\\images\\hardSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\hardSweets2-small.jpg", "\\images\\hardSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "\\images\\thumbnails\\hardSweets3-small.jpg", "\\images\\hardSweets3.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_SweetId",
                table: "ShoppingCartItems",
                column: "SweetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\chocolateSweets-small.jpg", "~\\images\\chocolateSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\chocolateSweets2-small.jpg", "~\\images\\chocolateSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\chocolateSweets3-small.jpg", "~\\images\\chocolateSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\fruitSweets-small.jpg", "~\\images\\fruitSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\fruitSweets2-small.jpg", "~\\images\\fruitSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\fruitSweets3-small.jpg", "~\\images\\fruitSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\gummySweets-small.jpg", "~\\images\\gummySweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\gummySweets2-small.jpg", "~\\images\\gummySweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\gummySweets3-small.jpg", "~\\images\\gummySweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\halloweenSweets-small.jpg", "~\\images\\halloweenSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\halloweenSweets2-small.jpg", "~\\images\\halloweenSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\halloweenSweets3-small.jpg", "~\\images\\halloweenSweets3.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\hardSweets-small.jpg", "~\\images\\hardSweets.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\hardSweets2-small.jpg", "~\\images\\hardSweets2.jpg" });

            migrationBuilder.UpdateData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImageThumbNailUrl", "ImageUrl" },
                values: new object[] { "~\\images\\thumbnails\\hardSweets3-small.jpg", "~\\images\\hardSweets3.jpg" });
        }
    }
}
