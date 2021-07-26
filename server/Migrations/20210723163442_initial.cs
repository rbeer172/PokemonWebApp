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
                    max_exp = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "moves",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    typing_name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    category = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    power = table.Column<int>(type: "int", nullable: true),
                    accuracy = table.Column<int>(type: "int", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
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
                    id = table.Column<int>(type: "int", nullable: false),
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
                    id = table.Column<int>(type: "int", nullable: false),
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

            migrationBuilder.InsertData(
                table: "abilities",
                columns: new[] { "ability_name", "description" },
                values: new object[,]
                {
                    { "Overgrow", "Increases the power of Grass-type moves by 50% when the ability-bearer's HP falls below a third of its maximum HP" },
                    { "Chlorophyll", "Doubles the ability-bearer's Speed during bright sunshine." }
                });

            migrationBuilder.InsertData(
                table: "accuracy_values",
                column: "accuracy",
                values: new object[]
                {
                    95,
                    90,
                    85,
                    80,
                    60,
                    70,
                    50,
                    30,
                    100,
                    75,
                    55
                });

            migrationBuilder.InsertData(
                table: "egg_groups",
                column: "name",
                values: new object[]
                {
                    "Grass",
                    "Monster"
                });

            migrationBuilder.InsertData(
                table: "evolution_group",
                column: "id",
                value: 1);

            migrationBuilder.InsertData(
                table: "move_categories",
                column: "category",
                values: new object[]
                {
                    "status",
                    "special",
                    "physical"
                });

            migrationBuilder.InsertData(
                table: "pokemon",
                columns: new[] { "pokemon_id", "attack", "defense", "description", "height", "hp", "max_exp", "pokdex_id", "pokemon_name", "special_attack", "special_defense", "species", "speed", "total", "weight" },
                values: new object[,]
                {
                    { 1, 49, 49, "A Grass/Poison type Pokémon introduced in Generation 1.", 0.7f, 45, 1059862, 1, "Bulbasaur", 65, 65, "Seed", 45, 318, 6.9f },
                    { 2, 62, 63, "A Grass/Poison type Pokémon introduced in Generation 1.", 1f, 60, 1059862, 2, "Ivysaur", 80, 80, "Seed", 60, 405, 13f },
                    { 3, 82, 83, "A Grass/Poison type Pokémon introduced in Generation 1.", 2f, 80, 1059862, 3, "Venusaur", 100, 100, "Seed", 80, 525, 100f }
                });

            migrationBuilder.InsertData(
                table: "power_values",
                column: "power",
                values: new object[]
                {
                    80,
                    95,
                    100,
                    110,
                    125,
                    140,
                    65,
                    150,
                    160,
                    200,
                    250,
                    130,
                    60,
                    70,
                    50,
                    45,
                    35,
                    30,
                    20,
                    18
                });

            migrationBuilder.InsertData(
                table: "power_values",
                column: "power",
                values: new object[]
                {
                    15,
                    10,
                    120,
                    90,
                    75,
                    40,
                    55
                });

            migrationBuilder.InsertData(
                table: "pp_values",
                column: "pp",
                values: new object[]
                {
                    40,
                    25,
                    5,
                    30,
                    20,
                    15,
                    10,
                    35
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
                    "flying",
                    "ground",
                    "fighting",
                    "ice",
                    "grass",
                    "electric",
                    "water",
                    "fire",
                    "normal",
                    "steel",
                    "poison",
                    "fairy"
                });

            migrationBuilder.InsertData(
                table: "evolution",
                columns: new[] { "id", "evolution_id", "evolved_pokemon", "friendship", "held_item", "level", "move", "other", "pokemon_id", "time", "trade", "use_item" },
                values: new object[,]
                {
                    { 1, 1, 2, false, null, 16, null, null, 1, null, false, null },
                    { 2, 1, 3, false, null, 32, null, null, 2, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "moves",
                columns: new[] { "name", "accuracy", "category", "description", "power", "pp", "priority", "typing_name" },
                values: new object[,]
                {
                    { "Poison Powder", 75, "status", "Target will be poisoned. Poisoned Pokémon lose 1⁄8 of their maximum HP each turn.", null, 35, 0, "poison" },
                    { "Petal Blizzard", 100, "physical", "Deals damage.", 90, 15, 0, "grass" },
                    { "Giga Drain", 100, "special", "Deals damage and the user will recover 50% of the HP drained.", 75, 10, 0, "grass" },
                    { "Petal Dance", 100, "special", "The user of Petal Dance attacks for 2-3 turns, during which it cannot switch out, and then becomes confused, for 1-4 attacking turns (50% chance in Generations 1-6). The damage received is as if the Pokémon attacks itself with a typeless 40 base power Physical attack. If Petal Dance is disrupted (e.g. if the move misses or the user cannot attack due to paralysis) then it will stop and not cause confusion.", 120, 10, 0, "grass" },
                    { "Solar Beam", 100, "special", "Charges the first turn then deals damage the second turn. If during sunlight or holding a power herb, deals damage the first turn.Rain, hail and sandstorm weather reduces power by 50%", 120, 10, 0, "grass" },
                    { "Swords Dance", null, "status", "Raises the user's Attack by two stages up to a max of six.", null, 20, 0, "normal" },
                    { "Tackle", 100, "physical", "A basic attack that deals damage.", 40, 35, 0, "normal" }
                });

            migrationBuilder.InsertData(
                table: "pokemon_abilities",
                columns: new[] { "id", "ability", "hidden", "pokemon_id" },
                values: new object[,]
                {
                    { 5, "Overgrow", false, 3 },
                    { 6, "Chlorophyll", true, 3 },
                    { 4, "Chlorophyll", true, 2 },
                    { 3, "Overgrow", false, 2 },
                    { 2, "Chlorophyll", true, 1 },
                    { 1, "Overgrow", false, 1 }
                });

            migrationBuilder.InsertData(
                table: "pokemon_egg_groups",
                columns: new[] { "id", "eggGroup", "pokemon_id" },
                values: new object[,]
                {
                    { 4, "Monster", 2 },
                    { 3, "Grass", 2 },
                    { 5, "Grass", 3 },
                    { 6, "Monster", 3 },
                    { 2, "Monster", 1 },
                    { 1, "Grass", 1 }
                });

            migrationBuilder.InsertData(
                table: "pokemon_evolution_group",
                columns: new[] { "id", "group_id", "pokemon_id" },
                values: new object[,]
                {
                    { 3, 1, 3 },
                    { 1, 1, 1 },
                    { 2, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "pokemon_types",
                columns: new[] { "id", "pokemon_id", "type" },
                values: new object[,]
                {
                    { 2, 1, "poison" },
                    { 6, 3, "poison" },
                    { 4, 2, "poison" },
                    { 1, 1, "grass" },
                    { 5, 3, "grass" },
                    { 3, 2, "grass" }
                });

            migrationBuilder.InsertData(
                table: "type_effectiveness",
                columns: new[] { "id", "attacking_type", "defending_type", "multiplier" },
                values: new object[,]
                {
                    { 35, "dark", "poison", 1f },
                    { 29, "flying", "poison", 1f },
                    { 12, "psychic", "grass", 1f },
                    { 30, "psychic", "poison", 2f },
                    { 13, "bug", "grass", 2f },
                    { 31, "bug", "poison", 0.5f },
                    { 14, "rock", "grass", 1f },
                    { 32, "rock", "poison", 1f },
                    { 15, "ghost", "grass", 1f },
                    { 11, "flying", "grass", 2f },
                    { 36, "steel", "poison", 1f },
                    { 33, "ghost", "poison", 1f }
                });

            migrationBuilder.InsertData(
                table: "type_effectiveness",
                columns: new[] { "id", "attacking_type", "defending_type", "multiplier" },
                values: new object[,]
                {
                    { 16, "dragon", "grass", 1f },
                    { 34, "dragon", "poison", 1f },
                    { 17, "dark", "grass", 1f },
                    { 18, "steel", "grass", 1f },
                    { 28, "ground", "poison", 2f },
                    { 8, "fighting", "grass", 1f },
                    { 27, "poison", "poison", 0.5f },
                    { 1, "normal", "grass", 1f },
                    { 2, "fire", "grass", 2f },
                    { 3, "water", "grass", 0.5f },
                    { 4, "electric", "grass", 0.5f },
                    { 5, "grass", "grass", 0.5f },
                    { 7, "ice", "grass", 2f },
                    { 19, "fairy", "grass", 1f },
                    { 9, "poison", "grass", 2f },
                    { 20, "normal", "poison", 1f },
                    { 21, "fire", "poison", 1f },
                    { 22, "water", "poison", 1f },
                    { 23, "electric", "poison", 1f },
                    { 24, "grass", "poison", 0.5f },
                    { 25, "ice", "poison", 1f },
                    { 26, "fighting", "poison", 0.5f },
                    { 10, "ground", "grass", 0.5f },
                    { 37, "fairy", "poison", 0.5f }
                });

            migrationBuilder.InsertData(
                table: "egg_moves",
                columns: new[] { "id", "move", "pokemon_id" },
                values: new object[,]
                {
                    { 2, "Petal Dance", 2 },
                    { 3, "Petal Dance", 3 },
                    { 1, "Petal Dance", 1 }
                });

            migrationBuilder.InsertData(
                table: "evolution_learned_moves",
                columns: new[] { "id", "move", "pokemon_id" },
                values: new object[] { 1, "Petal Blizzard", 3 });

            migrationBuilder.InsertData(
                table: "levelup_learned_moves",
                columns: new[] { "id", "level", "move", "pokemon_id" },
                values: new object[,]
                {
                    { 2, 15, "Poison Powder", 1 },
                    { 10, 1, "Petal Blizzard", 3 },
                    { 11, 1, "Petal Dance", 3 },
                    { 5, 15, "Poison Powder", 2 },
                    { 1, 1, "Tackle", 1 },
                    { 6, 50, "Solar Beam", 2 },
                    { 3, 36, "Solar Beam", 1 },
                    { 7, 1, "Tackle", 3 },
                    { 4, 1, "Tackle", 2 },
                    { 9, 58, "Solar Beam", 3 },
                    { 8, 15, "Poison Powder", 3 }
                });

            migrationBuilder.InsertData(
                table: "tm",
                columns: new[] { "id", "move_name" },
                values: new object[] { 28, "Giga Drain" });

            migrationBuilder.InsertData(
                table: "tr",
                columns: new[] { "id", "move_name" },
                values: new object[] { 1, "Swords Dance" });

            migrationBuilder.InsertData(
                table: "tm_learned_moves",
                columns: new[] { "id", "pokemon_id", "tm_id" },
                values: new object[,]
                {
                    { 1, 1, 28 },
                    { 2, 2, 28 },
                    { 3, 3, 28 }
                });

            migrationBuilder.InsertData(
                table: "tr_learned_moves",
                columns: new[] { "id", "pokemon_id", "tr_id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 }
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
                name: "IX_pokemon_evolution_group_group_id",
                table: "pokemon_evolution_group",
                column: "group_id");

            migrationBuilder.CreateIndex(
                name: "IX_pokemon_evolution_group_pokemon_id",
                table: "pokemon_evolution_group",
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
                column: "move_name",
                unique: true);

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
                column: "move_name",
                unique: true);

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
                column: "attacking_type");

            migrationBuilder.CreateIndex(
                name: "IX_type_effectiveness_defending_type",
                table: "type_effectiveness",
                column: "defending_type");
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
                name: "pokemon_evolution_group");

            migrationBuilder.DropTable(
                name: "pokemon_types");

            migrationBuilder.DropTable(
                name: "tm_learned_moves");

            migrationBuilder.DropTable(
                name: "tr_learned_moves");

            migrationBuilder.DropTable(
                name: "type_effectiveness");

            migrationBuilder.DropTable(
                name: "items");

            migrationBuilder.DropTable(
                name: "abilities");

            migrationBuilder.DropTable(
                name: "egg_groups");

            migrationBuilder.DropTable(
                name: "evolution_group");

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
