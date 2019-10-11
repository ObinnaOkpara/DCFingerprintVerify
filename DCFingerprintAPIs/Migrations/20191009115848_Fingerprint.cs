using Microsoft.EntityFrameworkCore.Migrations;

namespace DCFingerprintAPIs.Migrations
{
    public partial class Fingerprint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "FpAuthorised",
                table: "stafftab",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FpAuthorised",
                table: "stafftab");
        }
    }
}
