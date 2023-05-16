using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.ShopOnline.Migrations
{
    /// <inheritdoc />
    public partial class kaoutarAddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IconCSS",
                table: "ProductCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 3, "fas fa-spa", "Beauty" },
                    { 4, "fas fa-couch", "Furniture" },
                    { 5, "fas fa-headphones", "Electronics" },
                    { 6, "fas fa-shoe-prints", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "UseName" },
                values: new object[,]
                {
                    { 1, "test1@gmail.com", "Bob" },
                    { 2, "test2@gmail.com", "Sarah" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageURL", "Name", "Price", "qte" },
                values: new object[,]
                {
                    { 1, 3, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", "Glossier - Beauty Kit", 100.0, 100 },
                    { 4, 3, "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", "Schwarzkopf - Hair Care and Skin Care Kit", 50.0, 60 },
                    { 5, 3, "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", "Skin Care Kit", 30.0, 85 },
                    { 6, 5, "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100.0, 120 },
                    { 7, 5, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones", 40.0, 200 },
                    { 8, 5, "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones", 40.0, 300 },
                    { 9, 5, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod", 600.0, 20 },
                    { 10, 5, "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera", 500.0, 15 },
                    { 11, 5, "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy", 100.0, 60 },
                    { 12, 4, "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50.0, 212 },
                    { 13, 4, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50.0, 112 },
                    { 14, 4, "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70.0, 90 },
                    { 15, 4, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120.0, 95 },
                    { 16, 4, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15.0, 100 },
                    { 17, 4, "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20.0, 73 },
                    { 18, 6, "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers", 100.0, 50 },
                    { 19, 6, "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers", 150.0, 60 },
                    { 20, 6, "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers", 200.0, 70 },
                    { 21, 6, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers", 120.0, 120 },
                    { 22, 6, "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers", 200.0, 100 },
                    { 23, 6, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles", 50.0, 150 },
                    { 24, 3, "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", "Curology - Skin Care Kit", 50.0, 45 },
                    { 25, 3, "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", "Cocooil - Organic Coconut Oil", 20.0, 30 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Carts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "IconCSS",
                table: "ProductCategories");
        }
    }
}
