using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class AddPackagesAndOffersTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Packages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IconColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardHeight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ButtonOutline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Packages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "BackgroundColor", "ButtonOutline", "CardHeight", "IconColor", "Name", "Price", "SoftDelete", "TextColor" },
                values: new object[] { 1, "white", "primary", "pb-5 mt-5", "text-secondary", "Free Plan", 0m, false, "black" });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "BackgroundColor", "ButtonOutline", "CardHeight", "IconColor", "Name", "Price", "SoftDelete", "TextColor" },
                values: new object[] { 2, "bg-secondary", "light", "pt-3", "text-white", "Standart Plan", 120m, false, "text-white" });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "BackgroundColor", "ButtonOutline", "CardHeight", "IconColor", "Name", "Price", "SoftDelete", "TextColor" },
                values: new object[] { 3, "white", "primary", "pb-5 mt-5", "text-secondary", "Enterprise", 840m, false, "black" });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "Description", "PackageId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "5 Users", 1, false },
                    { 2, "2 TB Space", 1, false },
                    { 3, "Community Forums", 1, false },
                    { 4, "Email Support", 1, false },
                    { 5, "25 to 99 Users", 2, false },
                    { 6, "10 TB space", 2, false },
                    { 7, "Source Files", 2, false },
                    { 8, "Live Chat", 2, false },
                    { 9, "100 users or more", 3, false },
                    { 10, "80 TB space", 3, false },
                    { 11, "Full Access Sources", 3, false },
                    { 12, "Customizations", 3, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PackageId",
                table: "Offers",
                column: "PackageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Packages");
        }
    }
}
