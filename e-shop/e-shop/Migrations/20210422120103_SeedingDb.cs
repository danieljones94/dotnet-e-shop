using Microsoft.EntityFrameworkCore.Migrations;

namespace e_shop.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, null, "Chocolate" },
                    { 2, null, "Fruit Sweets" },
                    { 3, null, "Gummy Sweets" },
                    { 4, null, "Halloween Sweets" },
                    { 5, null, "Hard Boiled Sweets" }
                });

            migrationBuilder.InsertData(
                table: "Sweets",
                columns: new[] { "Id", "CategoryId", "Description", "ImageThumbNailUrl", "ImageUrl", "IsInStock", "IsOnSale", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\chocolateSweets-small.jpg", "~\\images\\chocolateSweets.jpg", true, true, "Assorted Chocolate", 4.99m },
                    { 2, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\chocolateSweets2-small.jpg", "~\\images\\chocolateSweets2.jpg", true, true, "Assorted Chocolate 2", 3.99m },
                    { 3, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\chocolateSweets3-small.jpg", "~\\images\\chocolateSweets3.jpg", true, true, "Assorted Chocolate 3", 2.99m },
                    { 4, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\fruitSweets-small.jpg", "~\\images\\fruitSweets.jpg", true, true, "Assorted Fruit Sweets", 1.99m },
                    { 5, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\fruitSweets2-small.jpg", "~\\images\\fruitSweets2.jpg", true, true, "Assorted Fruit Sweets 2", 4.99m },
                    { 6, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\fruitSweets3-small.jpg", "~\\images\\fruitSweets3.jpg", true, true, "Assorted Fruit Sweets 3", 1.49m },
                    { 7, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\gummySweets-small.jpg", "~\\images\\gummySweets.jpg", true, true, "Assorted Gummy Sweets 2", 0.59m },
                    { 8, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\gummySweets2-small.jpg", "~\\images\\gummySweets2.jpg", true, true, "Assorted Gummy Sweets", 1.49m },
                    { 9, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\gummySweets3-small.jpg", "~\\images\\gummySweets3.jpg", true, true, "Assorted Gummy Sweets 3", 6.19m },
                    { 10, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\halloweenSweets-small.jpg", "~\\images\\halloweenSweets.jpg", true, true, "Assorted Halloween Sweets", 3.49m },
                    { 11, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\halloweenSweets2-small.jpg", "~\\images\\halloweenSweets2.jpg", true, true, "Assorted Halloween Sweets 2", 2.49m },
                    { 12, 4, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\halloweenSweets3-small.jpg", "~\\images\\halloweenSweets3.jpg", true, true, "Assorted Halloween Sweets 3", 8.99m },
                    { 13, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\hardSweets-small.jpg", "~\\images\\hardSweets.jpg", true, true, "Assorted Hard Boiled Sweet", 1.99m },
                    { 14, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\hardSweets2-small.jpg", "~\\images\\hardSweets2.jpg", true, true, "Assorted Hard Boiled Sweets 2", 3.19m },
                    { 15, 5, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", "~\\images\\thumbnails\\hardSweets3-small.jpg", "~\\images\\hardSweets3.jpg", true, true, "Assorted Hard Boiled Sweets 3", 0.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sweets",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
