using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Language_Study_App.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishAllEntite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<int>(type: "int", nullable: false),
                    EnglishMean = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sentece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurkishMean = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PVs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishPV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<int>(type: "int", nullable: false),
                    EnglishMean = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sentece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurkishMean = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Translates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishTranslate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<int>(type: "int", nullable: false),
                    EnglishMean = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sentece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurkishMean = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Translates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnglishWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateType = table.Column<int>(type: "int", nullable: false),
                    EnglishMean = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sentece = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TurkishMean = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllEntities");

            migrationBuilder.DropTable(
                name: "PVs");

            migrationBuilder.DropTable(
                name: "Translates");

            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
