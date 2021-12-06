using Microsoft.EntityFrameworkCore.Migrations;

namespace KuzeyCodeFirst.Migrations
{
    public partial class DevamColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "DevamEtmiyor",
                table: "Urunler",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DevamEtmiyor",
                table: "Urunler");
        }
    }
}
