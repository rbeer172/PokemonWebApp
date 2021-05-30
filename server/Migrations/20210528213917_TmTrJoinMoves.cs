using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class TmTrJoinMoves : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tr_move_name",
                table: "tr");

            migrationBuilder.DropIndex(
                name: "IX_tm_move_name",
                table: "tm");

            migrationBuilder.CreateIndex(
                name: "IX_tr_move_name",
                table: "tr",
                column: "move_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tm_move_name",
                table: "tm",
                column: "move_name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_tr_move_name",
                table: "tr");

            migrationBuilder.DropIndex(
                name: "IX_tm_move_name",
                table: "tm");

            migrationBuilder.CreateIndex(
                name: "IX_tr_move_name",
                table: "tr",
                column: "move_name");

            migrationBuilder.CreateIndex(
                name: "IX_tm_move_name",
                table: "tm",
                column: "move_name");
        }
    }
}
