using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class AddMoreDataInWorksTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRecent",
                table: "Works",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CategoryId", "Description", "IsRecent", "SoftDelete" },
                values: new object[,]
                {
                    { 9, 1, "Ullamco laboris nisi ut aliquip ex", true, false },
                    { 10, 2, "Psum officia anim id est laborum.", true, false },
                    { 11, 3, "Sum dolor sit consencutur", true, false },
                    { 12, 3, "Lorem ipsum dolor sit amet", true, false },
                    { 13, 2, "Put enim ad minim veniam", true, false },
                    { 14, 1, "Mollit anim id est laborum.", true, false }
                });

            migrationBuilder.InsertData(
                table: "WorkImages",
                columns: new[] { "Id", "IsMain", "Name", "SoftDelete", "WorkId" },
                values: new object[,]
                {
                    { 17, true, "recent-work-01.jpg", false, 9 },
                    { 18, false, "recent-work-03.jpg", false, 9 },
                    { 19, true, "recent-work-02.jpg", false, 10 },
                    { 20, false, "recent-work-01.jpg", false, 10 },
                    { 21, true, "recent-work-03.jpg", false, 11 },
                    { 22, false, "recent-work-05.jpg", false, 11 },
                    { 23, true, "recent-work-04.jpg", false, 12 },
                    { 24, false, "recent-work-02.jpg", false, 12 },
                    { 25, true, "recent-work-05.jpg", false, 13 },
                    { 26, false, "recent-work-03.jpg", false, 13 },
                    { 27, true, "recent-work-06.jpg", false, 14 },
                    { 28, false, "recent-work-01.jpg", false, 14 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "WorkImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Works",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DropColumn(
                name: "IsRecent",
                table: "Works");
        }
    }
}
