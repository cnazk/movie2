using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class FixModelNamesandRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemaas_CinemaaId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemaas");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaaId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Cinemas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinemas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinemas_CinemaId",
                table: "Movies");

            migrationBuilder.DropTable(
                name: "Cinemas");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "CinemaaId",
                table: "Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Cinemaas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinemaas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaaId",
                table: "Movies",
                column: "CinemaaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinemaas_CinemaaId",
                table: "Movies",
                column: "CinemaaId",
                principalTable: "Cinemaas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
