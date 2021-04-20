using Microsoft.EntityFrameworkCore.Migrations;

namespace CofFeeShop.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Coffees",
                columns: table => new
                {
                    CoffeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageThumbnailUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCoffeeOfTheWeek = table.Column<bool>(type: "bit", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffees", x => x.CoffeeId);
                    table.ForeignKey(
                        name: "FK_Coffees_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoffeeId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Coffees_CoffeeId",
                        column: x => x.CoffeeId,
                        principalTable: "Coffees",
                        principalColumn: "CoffeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 1, "Strong Coffees", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 2, "Medium Blend Coffees", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[] { 3, "Seasonal Coffees", null });

            migrationBuilder.InsertData(
                table: "Coffees",
                columns: new[] { "CoffeeId", "CategoryId", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsCoffeeOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, "Our Home Blend has a medium body which is complemented by deep red fruit acidity, cocoa sweetness and a pleasant lingering finish.", "Home Blend Coffee", 12.95m, "Award-Winning Home Blend Coffee" },
                    { 4, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg", true, false, "If you like flavoured coffe this is for you", "HazelNut Coffee", 15.95m, "Delicious and tasty Hazelnut" },
                    { 7, 1, "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg", false, false, "a long fermentation process that ramps up both the fruity characteristics", "Grace", 15.95m, "a coffee that really stand out" },
                    { 2, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg", true, true, "an aroma of sweet caramel", "Red Blend Coffee", 18.95m, "little bit of luxury!" },
                    { 3, 2, "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", true, false, "a really strong coffee with lots of body and flavour.", "Colombian", 18.95m, "Pure blend" },
                    { 5, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg", true, false, "A natural processed coffee whilst avoiding any negative over-fermented notes", "Natural BURUI", 13.95m, "A natural processed coffee" },
                    { 6, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg", true, false, "fudge-like sweetness and chocolate notes.", "Flora", 17.95m, "perfect for winter days" },
                    { 8, 3, "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", true, true, "The coffee is rounded with milk chocolate notes.", "Vista", 12.95m, "a mix of bourbon varieties" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Coffees_CategoryId",
                table: "Coffees",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_CoffeeId",
                table: "ShoppingCartItems",
                column: "CoffeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Coffees");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
