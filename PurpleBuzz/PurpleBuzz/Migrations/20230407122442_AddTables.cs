using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderBackgrounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderBackgrounds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "SoftDelete", "Title" },
                values: new object[] { 1, "You are free to use this template for your commercial or business websites. You are not allowed to re-distribute this template ZIP file on any template collection websites. It is too easy to illegally copy and repost this template.", false, "Make Success for future" });

            migrationBuilder.InsertData(
                table: "SliderBackgrounds",
                columns: new[] { "Id", "Image", "SoftDelete" },
                values: new object[] { 1, "banner-bg-01.jpg", false });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "Description", "IsActive", "SoftDelete", "Title" },
                values: new object[,]
                {
                    { 1, "Purple Buzz is a corporate HTML template with Bootstrap 5 Beta 1. This CSS template is 100% free to download provided by <a rel=\"nofollow\" href=\"https://templatemo.com/page/1\" target=\"_parent\">TemplateMo</a>. Total 6 HTML pages included in this template. Icon fonts by <a rel=\"nofollow\" href=\"https://boxicons.com/\" target=\"_blank\">Boxicons</a>. Photos are from <a rel=\"nofollow\" href=\"https://unsplash.com/\" target=\"_blank\">Unsplash</a> and <a rel=\"nofollow\" href=\"https://icons8.com/\" target=\"_blank\">Icons 8</a>.", "active", false, "Develop <strong>Strategies</strong> for <br>your business" },
                    { 2, "You are not allowed to re-distribute this Purple Buzz HTML template as a downloadable ZIP file on any kind of Free CSS collection websites. This is strongly prohibited. Please contact TemplateMo for more information.", "deactive", false, "HTML CSS Template with Bootstrap 5 Beta 1" },
                    { 3, "Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat.", "deactive", false, "Cupidatat non proident, sunt in culpa qui officia" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SliderBackgrounds");

            migrationBuilder.DropTable(
                name: "Sliders");
        }
    }
}
