using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class typeEffectiveness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_type_effectiveness_attacking_type",
                table: "type_effectiveness");

            migrationBuilder.DropIndex(
                name: "IX_type_effectiveness_defending_type",
                table: "type_effectiveness");

            migrationBuilder.InsertData(
                table: "type_effectiveness",
                columns: new[] { "id", "attacking_type", "defending_type", "multiplier" },
                values: new object[,]
                {
                    { 1, "normal", "grass", 1f },
                    { 5, "grass", "grass", 0.5f },
                    { 9, "poison", "grass", 2f },
                    { 20, "normal", "poison", 1f },
                    { 24, "grass", "poison", 0.5f },
                    { 27, "poison", "poison", 0.5f }
                });

            migrationBuilder.InsertData(
                table: "typing",
                column: "typing_name",
                values: new object[]
                {
                    "dark",
                    "dragon",
                    "ghost",
                    "rock",
                    "bug",
                    "psychic",
                    "fighting",
                    "ground",
                    "steel",
                    "ice",
                    "electric",
                    "water",
                    "fire",
                    "flying",
                    "fairy"
                });

            migrationBuilder.InsertData(
                table: "type_effectiveness",
                columns: new[] { "id", "attacking_type", "defending_type", "multiplier" },
                values: new object[,]
                {
                    { 2, "fire", "grass", 2f },
                    { 36, "steel", "poison", 1f },
                    { 18, "steel", "grass", 1f },
                    { 35, "dark", "poison", 1f },
                    { 17, "dark", "grass", 1f },
                    { 34, "dragon", "poison", 1f },
                    { 16, "dragon", "grass", 1f },
                    { 33, "ghost", "poison", 1f },
                    { 15, "ghost", "grass", 1f },
                    { 32, "rock", "poison", 1f },
                    { 14, "rock", "grass", 1f },
                    { 31, "bug", "poison", 0.5f },
                    { 13, "bug", "grass", 2f },
                    { 30, "psychic", "poison", 2f },
                    { 12, "psychic", "grass", 1f },
                    { 29, "flying", "poison", 1f },
                    { 11, "flying", "grass", 2f },
                    { 28, "ground", "poison", 2f },
                    { 10, "ground", "grass", 0.5f },
                    { 26, "fighting", "poison", 0.5f },
                    { 8, "fighting", "grass", 1f },
                    { 25, "ice", "poison", 1f },
                    { 7, "ice", "grass", 2f },
                    { 23, "electric", "poison", 1f },
                    { 4, "electric", "grass", 0.5f },
                    { 22, "water", "poison", 1f },
                    { 3, "water", "grass", 0.5f },
                    { 21, "fire", "poison", 1f },
                    { 19, "fairy", "grass", 1f },
                    { 37, "fairy", "poison", 0.5f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_type_effectiveness_attacking_type",
                table: "type_effectiveness",
                column: "attacking_type");

            migrationBuilder.CreateIndex(
                name: "IX_type_effectiveness_defending_type",
                table: "type_effectiveness",
                column: "defending_type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_type_effectiveness_attacking_type",
                table: "type_effectiveness");

            migrationBuilder.DropIndex(
                name: "IX_type_effectiveness_defending_type",
                table: "type_effectiveness");

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "type_effectiveness",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "bug");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "dark");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "dragon");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "electric");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "fairy");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "fighting");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "fire");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "flying");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "ghost");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "ground");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "ice");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "psychic");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "rock");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "steel");

            migrationBuilder.DeleteData(
                table: "typing",
                keyColumn: "typing_name",
                keyValue: "water");

            migrationBuilder.CreateIndex(
                name: "IX_type_effectiveness_attacking_type",
                table: "type_effectiveness",
                column: "attacking_type",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_type_effectiveness_defending_type",
                table: "type_effectiveness",
                column: "defending_type",
                unique: true);
        }
    }
}
