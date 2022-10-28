using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerTask.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "slackUsername",
                table: "Infos",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Infos",
                table: "Infos",
                column: "slackUsername");

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "slackUsername", "age", "backend", "bio" },
                values: new object[] { "Ese_O", 28, true, "Hereos never die!" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Infos",
                table: "Infos");

            migrationBuilder.DeleteData(
                table: "Infos",
                keyColumn: "slackUsername",
                keyValue: "Ese_O");

            migrationBuilder.AlterColumn<string>(
                name: "slackUsername",
                table: "Infos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
