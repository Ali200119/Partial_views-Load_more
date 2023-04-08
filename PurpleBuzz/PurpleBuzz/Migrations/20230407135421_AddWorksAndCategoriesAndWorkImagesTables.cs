using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class AddWorksAndCategoriesAndWorkImagesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Filter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Works_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WorkImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    WorkId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkImages_Works_WorkId",
                        column: x => x.WorkId,
                        principalTable: "Works",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Filter", "Name", "SoftDelete" },
                values: new object[] { 1, "graphic", "Graphics", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Filter", "Name", "SoftDelete" },
                values: new object[] { 2, "ui", "UI/UX", false });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Filter", "Name", "SoftDelete" },
                values: new object[] { 3, "branding", "Branding", false });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CategoryId", "Description", "SoftDelete" },
                values: new object[,]
                {
                    { 1, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 3, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 6, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false },
                    { 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false }
                });

            migrationBuilder.InsertData(
                table: "WorkImages",
                columns: new[] { "Id", "IsMain", "Name", "SoftDelete", "WorkId" },
                values: new object[,]
                {
                    { 1, true, "services-01.jpg", false, 1 },
                    { 2, false, "services-01.jpg", false, 1 },
                    { 3, true, "services-01.jpg", false, 2 },
                    { 4, false, "services-01.jpg", false, 2 },
                    { 5, true, "services-01.jpg", false, 3 },
                    { 6, false, "services-01.jpg", false, 3 },
                    { 7, true, "services-01.jpg", false, 4 },
                    { 8, false, "services-01.jpg", false, 4 },
                    { 9, true, "services-01.jpg", false, 5 },
                    { 10, false, "services-01.jpg", false, 5 },
                    { 11, true, "services-01.jpg", false, 6 },
                    { 12, false, "services-01.jpg", false, 6 },
                    { 13, true, "services-01.jpg", false, 7 },
                    { 14, false, "services-01.jpg", false, 7 },
                    { 15, true, "services-01.jpg", false, 8 },
                    { 16, false, "services-01.jpg", false, 8 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkImages_WorkId",
                table: "WorkImages",
                column: "WorkId");

            migrationBuilder.CreateIndex(
                name: "IX_Works_CategoryId",
                table: "Works",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkImages");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
