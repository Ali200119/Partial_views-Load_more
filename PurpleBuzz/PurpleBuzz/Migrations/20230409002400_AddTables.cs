using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PurpleBuzz.Migrations
{
    public partial class AddTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.Id);
                });

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
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Subtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRecent = table.Column<bool>(type: "bit", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postiton = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamMembers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
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
                table: "Abouts",
                columns: new[] { "Id", "BackgroundImage", "Description", "SoftDelete", "Title" },
                values: new object[] { 1, "banner-img-02.svg", "Vector illustration credit goes to <a rel=\"nofollow\" href=\"http://freepik.com/\" target=\"_blank\">FreePik</a> website. Purple Buzz is provided by TemplateMo. Lorem ipsum dolor sit amet, consectetur.", false, "About Us" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Filter", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "graphic", "Graphics", false },
                    { 2, "ui", "UI/UX", false },
                    { 3, "branding", "Branding", false }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "BackgroundImage", "Description", "SoftDelete", "Subtitle", "Title" },
                values: new object[] { 1, "banner-img-01.svg", "Vector illustration is from <a rel=\"nofollow\" href=\"https://storyset.com/\" target=\"_blank\">StorySet</a>. Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse ultrices gravida.", false, "Elit, sed do eiusmod tempor", "Contact" });

            migrationBuilder.InsertData(
                table: "Packages",
                columns: new[] { "Id", "BackgroundColor", "ButtonOutline", "CardHeight", "IconColor", "Name", "Price", "SoftDelete", "TextColor" },
                values: new object[,]
                {
                    { 1, "white", "primary", "pb-5 mt-5", "text-secondary", "Free Plan", 0m, false, "black" },
                    { 2, "bg-secondary", "light", "pt-3", "text-white", "Standart Plan", 120m, false, "text-white" },
                    { 3, "white", "primary", "pb-5 mt-5", "text-secondary", "Enterprise", 840m, false, "black" }
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

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Description", "SoftDelete" },
                values: new object[] { 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.", false });

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

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "FullName", "Image", "Postiton", "SoftDelete", "TeamId" },
                values: new object[,]
                {
                    { 1, "John Doe", "team-01.jpg", "Business Development", false, 1 },
                    { 2, "Jane Doe", "team-02.jpg", "Media Development", false, 1 },
                    { 3, "Sam", "team-03.jpg", "Developer", false, 1 }
                });

            migrationBuilder.InsertData(
                table: "Works",
                columns: new[] { "Id", "CategoryId", "Description", "IsRecent", "SoftDelete" },
                values: new object[,]
                {
                    { 1, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 2, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 3, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 4, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 5, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 6, 3, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 7, 2, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
                    { 8, 1, "Lorem ipsum dolor sit amet, consectetur adipisicing", false, false },
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
                    { 1, true, "services-01.jpg", false, 1 },
                    { 2, false, "services-06.jpg", false, 1 },
                    { 3, true, "services-02.jpg", false, 2 },
                    { 4, false, "services-04.jpg", false, 2 },
                    { 5, true, "services-03.jpg", false, 3 },
                    { 6, false, "services-01.jpg", false, 3 },
                    { 7, true, "services-04.jpg", false, 4 },
                    { 8, false, "services-08.jpg", false, 4 },
                    { 9, true, "services-05.jpg", false, 5 },
                    { 10, false, "services-02.jpg", false, 5 },
                    { 11, true, "services-06.jpg", false, 6 },
                    { 12, false, "services-08.jpg", false, 6 },
                    { 13, true, "services-07.jpg", false, 7 },
                    { 14, false, "services-03.jpg", false, 7 },
                    { 15, true, "services-08.jpg", false, 8 },
                    { 16, false, "services-05.jpg", false, 8 },
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

            migrationBuilder.CreateIndex(
                name: "IX_Offers_PackageId",
                table: "Offers",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMembers_TeamId",
                table: "TeamMembers",
                column: "TeamId");

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
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SliderBackgrounds");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "WorkImages");

            migrationBuilder.DropTable(
                name: "Packages");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
