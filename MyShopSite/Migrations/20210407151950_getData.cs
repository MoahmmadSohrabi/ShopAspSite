using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopSite.Migrations
{
    public partial class getData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                type: "Money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 1, 23000m, 25 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 2, 100000m, 45 });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Price", "QuantityInStock" },
                values: new object[] { 3, 350000m, 60 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 1, "همراه با تخفیف 20%این کالا محصول کشور کره می باشد ", 1, "جاروبرقی" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 2, "برنج شمال کشور ایران ", 2, "برنج ایرانی" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ItemId", "Name" },
                values: new object[] { 3, "تی شرت مردانه با تنوع رنگ بندی و ارسال رایگان به همه ی شهر ها", 3, "تی شرت مردانه" });

            migrationBuilder.InsertData(
                table: "CategoryToProducts",
                columns: new[] { "ProductId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryToProducts",
                keyColumns: new[] { "ProductId", "CategoryId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Items",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "Money");
        }
    }
}
