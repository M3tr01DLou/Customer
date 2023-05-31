using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Customer.API.Migrations
{
    /// <inheritdoc />
    public partial class AddUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(170)", maxLength: 170, nullable: true),
                    Login = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    AspId = table.Column<int>(type: "int", nullable: true),
                    Organization = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Administrator = table.Column<bool>(type: "bit", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Asps_AspId",
                        column: x => x.AspId,
                        principalTable: "Asps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_AspId",
                table: "Users",
                column: "AspId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
