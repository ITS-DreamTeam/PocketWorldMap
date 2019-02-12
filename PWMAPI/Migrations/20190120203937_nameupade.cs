using Microsoft.EntityFrameworkCore.Migrations;

namespace PWMAPI.Migrations
{
    public partial class nameupade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MakerId",
                table: "Markers",
                newName: "MarkerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MarkerId",
                table: "Markers",
                newName: "MakerId");
        }
    }
}
