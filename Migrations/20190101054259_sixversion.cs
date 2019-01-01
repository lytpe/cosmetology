using Microsoft.EntityFrameworkCore.Migrations;

namespace Cosmetology.Migrations
{
    public partial class sixversion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ArticleSideName",
                table: "Article",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ArticleSideName",
                table: "Article");
        }
    }
}
