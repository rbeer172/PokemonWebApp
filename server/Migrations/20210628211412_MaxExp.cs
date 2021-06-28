using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class MaxExp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "growth_rate",
                table: "pokemon");

            migrationBuilder.AddColumn<int>(
                name: "max_exp",
                table: "pokemon",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 1,
                column: "max_exp",
                value: 1059862);

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 2,
                column: "max_exp",
                value: 1059862);

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 3,
                column: "max_exp",
                value: 1059862);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "max_exp",
                table: "pokemon");

            migrationBuilder.AddColumn<string>(
                name: "growth_rate",
                table: "pokemon",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 1,
                column: "growth_rate",
                value: "medium slow");

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 2,
                column: "growth_rate",
                value: "medium slow");

            migrationBuilder.UpdateData(
                table: "pokemon",
                keyColumn: "pokemon_id",
                keyValue: 3,
                column: "growth_rate",
                value: "medium slow");
        }
    }
}
