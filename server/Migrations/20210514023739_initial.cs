using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "abilities",
                columns: table => new
                {
                    ability_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_abilities", x => x.ability_name);
                });

            migrationBuilder.CreateTable(
                name: "accuracy_values",
                columns: table => new
                {
                    accuracy = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accuracy_values", x => x.accuracy);
                });

            migrationBuilder.CreateTable(
                name: "egg_groups",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_egg_groups", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "evolution_group",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evolution_group", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "items",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_items", x => x.name);
                });

            migrationBuilder.CreateTable(
                name: "move_categories",
                columns: table => new
                {
                    category = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_move_categories", x => x.category);
                });

            migrationBuilder.CreateTable(
                name: "pokemon",
                columns: table => new
                {
                    pokemon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokdex_id = table.Column<int>(type: "int", nullable: false),
                    pokemon_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    species = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    height = table.Column<float>(type: "real", nullable: false),
                    weight = table.Column<float>(type: "real", nullable: false),
                    growth_rate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    hp = table.Column<int>(type: "int", nullable: false),
                    attack = table.Column<int>(type: "int", nullable: false),
                    defense = table.Column<int>(type: "int", nullable: false),
                    special_attack = table.Column<int>(type: "int", nullable: false),
                    special_defense = table.Column<int>(type: "int", nullable: false),
                    speed = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon", x => x.pokemon_id);
                });

            migrationBuilder.CreateTable(
                name: "power_values",
                columns: table => new
                {
                    power = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_power_values", x => x.power);
                });

            migrationBuilder.CreateTable(
                name: "pp_values",
                columns: table => new
                {
                    pp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pp_values", x => x.pp);
                });

            migrationBuilder.CreateTable(
                name: "typing",
                columns: table => new
                {
                    typing_name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typing", x => x.typing_name);
                });

            migrationBuilder.CreateTable(
                name: "pokemon_abilities",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    ability = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    hidden = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_abilities", x => x.id);
                    table.ForeignKey(
                        name: "FK_pokemon_abilities_abilities_ability",
                        column: x => x.ability,
                        principalTable: "abilities",
                        principalColumn: "ability_name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pokemon_abilities_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pokemon_egg_groups",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    eggGroup = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_egg_groups", x => x.id);
                    table.ForeignKey(
                        name: "FK_pokemon_egg_groups_egg_groups_eggGroup",
                        column: x => x.eggGroup,
                        principalTable: "egg_groups",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pokemon_egg_groups_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "moves",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    typing_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    power = table.Column<int>(type: "int", nullable: false),
                    accuracy = table.Column<int>(type: "int", nullable: false),
                    pp = table.Column<int>(type: "int", nullable: false),
                    priority = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moves", x => x.name);
                    table.ForeignKey(
                        name: "FK_moves_accuracy_values_accuracy",
                        column: x => x.accuracy,
                        principalTable: "accuracy_values",
                        principalColumn: "accuracy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moves_move_categories_category",
                        column: x => x.category,
                        principalTable: "move_categories",
                        principalColumn: "category",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moves_power_values_power",
                        column: x => x.power,
                        principalTable: "power_values",
                        principalColumn: "power",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moves_pp_values_pp",
                        column: x => x.pp,
                        principalTable: "pp_values",
                        principalColumn: "pp",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_moves_typing_typing_name",
                        column: x => x.typing_name,
                        principalTable: "typing",
                        principalColumn: "typing_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pokemon_types",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    type = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pokemon_types", x => x.id);
                    table.ForeignKey(
                        name: "FK_pokemon_types_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pokemon_types_typing_type",
                        column: x => x.type,
                        principalTable: "typing",
                        principalColumn: "typing_name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "type_effectiveness",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    attacking_type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    defending_type = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    multiplier = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_type_effectiveness", x => x.id);
                    table.ForeignKey(
                        name: "FK_type_effectiveness_typing_attacking_type",
                        column: x => x.attacking_type,
                        principalTable: "typing",
                        principalColumn: "typing_name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_type_effectiveness_typing_defending_type",
                        column: x => x.defending_type,
                        principalTable: "typing",
                        principalColumn: "typing_name",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "egg_moves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    move = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_egg_moves", x => x.id);
                    table.ForeignKey(
                        name: "FK_egg_moves_moves_move",
                        column: x => x.move,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_egg_moves_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "evolution",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    evolution_id = table.Column<int>(type: "int", nullable: false),
                    evolved_pokemon = table.Column<int>(type: "int", nullable: false),
                    level = table.Column<int>(type: "int", nullable: true),
                    held_item = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    use_item = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    friendship = table.Column<bool>(type: "bit", nullable: false),
                    move = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    trade = table.Column<bool>(type: "bit", nullable: false),
                    other = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evolution", x => x.id);
                    table.ForeignKey(
                        name: "FK_evolution_evolution_group_evolution_id",
                        column: x => x.evolution_id,
                        principalTable: "evolution_group",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evolution_items_held_item",
                        column: x => x.held_item,
                        principalTable: "items",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evolution_items_use_item",
                        column: x => x.use_item,
                        principalTable: "items",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evolution_moves_move",
                        column: x => x.move,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evolution_pokemon_evolved_pokemon",
                        column: x => x.evolved_pokemon,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_evolution_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "evolution_learned_moves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    move = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_evolution_learned_moves", x => x.id);
                    table.ForeignKey(
                        name: "FK_evolution_learned_moves_moves_move",
                        column: x => x.move,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_evolution_learned_moves_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "levelup_learned_moves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    move = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    level = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_levelup_learned_moves", x => x.id);
                    table.ForeignKey(
                        name: "FK_levelup_learned_moves_moves_move",
                        column: x => x.move,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_levelup_learned_moves_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tm",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    move_name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tm", x => x.id);
                    table.ForeignKey(
                        name: "FK_tm_moves_move_name",
                        column: x => x.move_name,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tr",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    move_name = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr", x => x.id);
                    table.ForeignKey(
                        name: "FK_tr_moves_move_name",
                        column: x => x.move_name,
                        principalTable: "moves",
                        principalColumn: "name",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tm_learned_moves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    tm_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tm_learned_moves", x => x.id);
                    table.ForeignKey(
                        name: "FK_tm_learned_moves_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tm_learned_moves_tm_tm_id",
                        column: x => x.tm_id,
                        principalTable: "tm",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tr_learned_moves",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pokemon_id = table.Column<int>(type: "int", nullable: false),
                    tr_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_learned_moves", x => x.id);
                    table.ForeignKey(
                        name: "FK_tr_learned_moves_pokemon_pokemon_id",
                        column: x => x.pokemon_id,
                        principalTable: "pokemon",
                        principalColumn: "pokemon_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tr_learned_moves_tr_tr_id",
                        column: x => x.tr_id,
                        principalTable: "tr",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_egg_moves_move",
                table: "egg_moves",
                column: "move");

            migrationBuilder.CreateIndex(
                name: "IX_egg_moves_pokemon_id",
                table: "egg_moves",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_evolution_id",
                table: "evolution",
                column: "evolution_id");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_evolved_pokemon",
                table: "evolution",
                column: "evolved_pokemon",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_evolution_held_item",
                table: "evolution",
                column: "held_item");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_move",
                table: "evolution",
                column: "move");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_pokemon_id",
                table: "evolution",
                column: "pokemon_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_evolution_use_item",
                table: "evolution",
                column: "use_item");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_learned_moves_move",
                table: "evolution_learned_moves",
                column: "move");

            migrationBuilder.CreateIndex(
                name: "IX_evolution_learned_moves_pokemon_id",
                table: "evolution_learned_moves",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_levelup_learned_moves_move",
                table: "levelup_learned_moves",
                column: "move");

            migrationBuilder.CreateIndex(
                name: "IX_levelup_learned_moves_pokemon_id",
                table: "levelup_learned_moves",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_moves_accuracy",
                table: "moves",
                column: "accuracy");

            migrationBuilder.CreateIndex(
                name: "IX_moves_category",
                table: "moves",
                column: "category");

            migrationBuilder.CreateIndex(
                name: "IX_moves_power",
                table: "moves",
                column: "power");

            migrationBuilder.CreateIndex(
                name: "IX_moves_pp",
                table: "moves",
                column: "pp");

            migrationBuilder.CreateIndex(
                name: "IX_moves_typing_name",
                table: "moves",
                column: "typing_name");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_abilities_ability",
                table: "pokemon_abilities",
                column: "ability");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_abilities_pokemon_id",
                table: "pokemon_abilities",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_egg_groups_eggGroup",
                table: "pokemon_egg_groups",
                column: "eggGroup");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_egg_groups_pokemon_id",
                table: "pokemon_egg_groups",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_types_pokemon_id",
                table: "pokemon_types",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_types_type",
                table: "pokemon_types",
                column: "type");

            migrationBuilder.CreateIndex(
                name: "IX_tm_move_name",
                table: "tm",
                column: "move_name");

            migrationBuilder.CreateIndex(
                name: "IX_tm_learned_moves_pokemon_id",
                table: "tm_learned_moves",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_tm_learned_moves_tm_id",
                table: "tm_learned_moves",
                column: "tm_id");

            migrationBuilder.CreateIndex(
                name: "IX_tr_move_name",
                table: "tr",
                column: "move_name");

            migrationBuilder.CreateIndex(
                name: "IX_tr_learned_moves_pokemon_id",
                table: "tr_learned_moves",
                column: "pokemon_id");

            migrationBuilder.CreateIndex(
                name: "IX_tr_learned_moves_tr_id",
                table: "tr_learned_moves",
                column: "tr_id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "egg_moves");

            migrationBuilder.DropTable(
                name: "evolution");

            migrationBuilder.DropTable(
                name: "evolution_learned_moves");

            migrationBuilder.DropTable(
                name: "levelup_learned_moves");

            migrationBuilder.DropTable(
                name: "pokemon_abilities");

            migrationBuilder.DropTable(
                name: "pokemon_egg_groups");

            migrationBuilder.DropTable(
                name: "pokemon_types");

            migrationBuilder.DropTable(
                name: "tm_learned_moves");

            migrationBuilder.DropTable(
                name: "tr_learned_moves");

            migrationBuilder.DropTable(
                name: "type_effectiveness");

            migrationBuilder.DropTable(
                name: "evolution_group");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "abilities");

            migrationBuilder.DropTable(
                name: "egg_groups");

            migrationBuilder.DropTable(
                name: "tm");

            migrationBuilder.DropTable(
                name: "pokemon");

            migrationBuilder.DropTable(
                name: "tr");

            migrationBuilder.DropTable(
                name: "moves");

            migrationBuilder.DropTable(
                name: "accuracy_values");

            migrationBuilder.DropTable(
                name: "move_categories");

            migrationBuilder.DropTable(
                name: "power_values");

            migrationBuilder.DropTable(
                name: "pp_values");

            migrationBuilder.DropTable(
                name: "typing");
        }
    }
}
