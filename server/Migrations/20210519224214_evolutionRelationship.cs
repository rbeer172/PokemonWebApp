using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class evolutionRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pokemon_evolution_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    group_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_evolution_group", x => x.id);
                    table.ForeignKey(
                        name: "FK_pokemon_evolution_group_evolution_group_group_id",
                        column: x => x.group_id,
                        principalTable: "evolution_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pokemon_evolution_group_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "pokemon_evolution_group",
                columns: new[] { "id", "group_id", "pokemon_id" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "pokemon_evolution_group",
                columns: new[] { "id", "group_id", "pokemon_id" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "pokemon_evolution_group",
                columns: new[] { "id", "group_id", "pokemon_id" },
                values: new object[] { 3, 1, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_evolution_group_group_id",
                table: "pokemon_evolution_group",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_evolution_group_pokemon_id",
                table: "pokemon_evolution_group",
                column: "pokemon_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pokemon_evolution_group");
        }
    }
}
