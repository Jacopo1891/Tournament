using Microsoft.EntityFrameworkCore.Migrations;

namespace Tournament.DB.Migrations
{
    public partial class FixNameFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Competitions_TournamentId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "TournamentId",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Matches",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CompetitionId",
                table: "Matches",
                column: "CompetitionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Competitions_CompetitionId",
                table: "Matches",
                column: "CompetitionId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matches_Competitions_CompetitionId",
                table: "Matches");

            migrationBuilder.DropIndex(
                name: "IX_Matches_CompetitionId",
                table: "Matches");

            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Matches");

            migrationBuilder.AddColumn<int>(
                name: "TournamentId",
                table: "Matches",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Matches_TournamentId",
                table: "Matches",
                column: "TournamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Matches_Competitions_TournamentId",
                table: "Matches",
                column: "TournamentId",
                principalTable: "Competitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
