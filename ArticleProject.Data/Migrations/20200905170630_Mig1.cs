using Microsoft.EntityFrameworkCore.Migrations;

namespace ArticleProject.Data.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    CategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: false),
                    PostID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Images_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "Admin", "09.05.2020 20:06:29", "Yazılıma Dair Her Şey", "Yazılım", "Admin", "09.05.2020 20:06:29" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 2, "Admin", "09.05.2020 20:06:29", "Spora Dair Her Şey", "Spor", "Admin", "09.05.2020 20:06:29" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "CategoryID", "CreatedBy", "CreatedDate", "Description", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, "Admin", "09.05.2020 20:06:29", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Yazılıma Başlangıç", "Admin", "09.05.2020 20:06:29" },
                    { 2, 1, "Admin", "09.05.2020 20:06:29", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Asp.Net Core Başlangıç", "Admin", "09.05.2020 20:06:29" },
                    { 3, 2, "Admin", "09.05.2020 20:06:29", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Dört Büyüklerde Transfer Hız Kesmiyor !", "Admin", "09.05.2020 20:06:29" },
                    { 4, 2, "Admin", "09.05.2020 20:06:29", "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", "Basketbol Takımımız Avrupa Yolcusu", "Admin", "09.05.2020 20:06:29" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Email", "FullName", "PostID", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", "09.05.2020 20:06:29", "kadirdinc34@gmail.com", "Kadir DİNÇ", 1, "Admin", "09.05.2020 20:06:29" },
                    { 2, "Admin", "09.05.2020 20:06:29", "kadirdinc34@gmail.com", "Kadir DİNÇ", 3, "Admin", "09.05.2020 20:06:29" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ID", "CreatedBy", "CreatedDate", "Description", "ImageUrl", "PostID", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Admin", "09.05.2020 20:06:29", "Yazılım Hayattır", "../yazilim.jpg", 1, "Admin", "09.05.2020 20:06:29" },
                    { 2, "Admin", "09.05.2020 20:06:29", "DÖRT BÜYÜKLER LOGO", "../dortBuyukler.jpg", 3, "Admin", "09.05.2020 20:06:29" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PostID",
                table: "Images",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryID",
                table: "Posts",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
