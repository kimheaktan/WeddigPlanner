using Microsoft.EntityFrameworkCore.Migrations;

namespace WeddingPlanner.Migrations
{
    public partial class migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hours",
                table: "Weddings");

            migrationBuilder.DropColumn(
                name: "Minutes",
                table: "Weddings");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hours",
                table: "Weddings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Minutes",
                table: "Weddings",
                nullable: true);
        }
    }
}
