using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BaseProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_DataCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeDescription", "Đây là mô tả của Web_Blog" },
                    { "HomeKeyWord", "Đây là từ khóa của Web_Blog" },
                    { "HomeTitle", "Đây là trang chủ của Web_Blog" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoriesID", "Name" },
                values: new object[,]
                {
                    { 1, "BÓNG ĐÁ" },
                    { 2, "THẾ GIỚI" },
                    { 3, "XÃ HỘI" },
                    { 4, "VĂN HÓA" },
                    { 5, "KINH TẾ" },
                    { 6, "GIÁO DỤC" },
                    { 7, "THỂ THAO" },
                    { 8, "GIẢI TRÍ" },
                    { 9, "PHÁP LUẬT" },
                    { 10, "CÔNG NGHỆ" },
                    { 11, "KHOA HỌC" },
                    { 12, "ĐỜI SỐNG " },
                    { 13, "XE CỘ" },
                    { 14, "NHÀ ĐẤT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyWord");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoriesID",
                keyValue: 14);
        }
    }
}
