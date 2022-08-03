using Microsoft.EntityFrameworkCore.Migrations;

namespace challenge.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Content = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { "13ce93ef-00f0-4fd9-bad0-b4dd9b6bd64a", "1 Bund Möhren\r\n5 Äpfel\r\n2 Bananen\r\nKiste Bier", "Einkaufszettel" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { "2a1f9ad0-808a-4881-b03d-24c57ecdce5d", "Challenge umsetzen", "Arbeit" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { "4958d9b7-44e5-409a-8062-497769b5fcb2", "Miete am 1. überweisen", "Bank" });

            migrationBuilder.InsertData(
                table: "Notes",
                columns: new[] { "Id", "Content", "Title" },
                values: new object[] { "ab858028-3d7f-448c-b890-e57bca294fc6", "wird 70, anrufen!!!!!!!!!", "Schwiegermutter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
