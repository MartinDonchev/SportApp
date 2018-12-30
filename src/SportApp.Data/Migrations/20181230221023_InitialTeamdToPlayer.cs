using Microsoft.EntityFrameworkCore.Migrations;

namespace SportApp.Data.Migrations
{
    public partial class InitialTeamdToPlayer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Sponsor",
                table: "Tournaments",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Television",
                table: "Tournaments",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Players",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Sponsor",
                table: "Tournaments");

            migrationBuilder.DropColumn(
                name: "Television",
                table: "Tournaments");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Players",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
