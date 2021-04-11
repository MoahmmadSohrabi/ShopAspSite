using Microsoft.EntityFrameworkCore.Migrations;

namespace MyShopSite.Migrations
{
    public partial class seedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "تجهیزات خانگی", "لوازم برقی" },
                    { 2, " همراه با تخفیف ویژه", "خوراکی ها" },
                    { 3, "تنوع پوشاک مردانه و زنانه", "پوشاک" },
                    { 4, "شامل بدلیجات،نقره و طلا", " زیورآلات" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
