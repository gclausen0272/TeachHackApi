using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace qrattend.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true),
                    MiddleName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true),
                    LastName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true),
                    PictureUrl = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true),
                    UserName = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true),
                    Password = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", maxLength: 2083, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teachers");
        }
    }
}
