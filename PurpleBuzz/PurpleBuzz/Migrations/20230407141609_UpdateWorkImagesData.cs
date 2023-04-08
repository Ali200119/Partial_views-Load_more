using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class UpdateWorkImagesData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "services-06.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "services-02.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "services-04.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "services-03.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "services-04.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "services-08.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "services-05.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "services-02.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "services-06.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "services-08.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "services-07.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "services-03.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "services-08.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "services-05.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "services-01.jpg");

            migrationBuilder.UpdateData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "services-01.jpg");
        }
    }
}
