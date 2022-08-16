using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Tracking_v6.Migrations
{
    public partial class SevenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "category",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "rate",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "category",
                table: "Book",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "rate",
                table: "Book",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
