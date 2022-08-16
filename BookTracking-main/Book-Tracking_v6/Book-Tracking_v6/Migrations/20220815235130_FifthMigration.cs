using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Tracking_v6.Migrations
{
    public partial class FifthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "catID",
                table: "Book");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "catID",
                table: "Book",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
