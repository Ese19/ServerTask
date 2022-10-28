using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerTask.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    slackUsername = table.Column<string>(type: "text", nullable: true),
                    backend = table.Column<bool>(type: "boolean", nullable: false),
                    age = table.Column<int>(type: "integer", nullable: false),
                    bio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");
        }
    }
}
