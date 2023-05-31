using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Customer.API.Migrations
{
    /// <inheritdoc />
    public partial class ModifyAspTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Asps",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Asps");
        }
    }
}
