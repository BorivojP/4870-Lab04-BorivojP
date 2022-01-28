using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Code1st.Data.Migrations
{
    public partial class Lab04v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: "BC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: "ON");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: "QC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode",
                value: "MB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: null);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                column: "ProvinceCode",
                value: null);
        }
    }
}
