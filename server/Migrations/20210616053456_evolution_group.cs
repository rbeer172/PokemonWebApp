using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class evolution_group : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 2,
                column: "hidden",
                value: true);

            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 4,
                column: "hidden",
                value: true);

            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 6,
                column: "hidden",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 2,
                column: "hidden",
                value: false);

            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 4,
                column: "hidden",
                value: false);

            migrationBuilder.UpdateData(
                table: "pokemon_abilities",
                keyColumn: "id",
                keyValue: 6,
                column: "hidden",
                value: false);
        }
    }
}
