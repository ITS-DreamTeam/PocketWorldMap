using Microsoft.EntityFrameworkCore.Migrations;

namespace PWMAPI.Migrations
{
    public partial class latAndLongAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Latitude",
                table: "Markers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Longitude",
                table: "Markers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "Markers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "Markers");
        }
    }
}
