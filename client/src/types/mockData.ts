/* eslint-disable import/prefer-default-export */
export const pokemonList: Array<Pokemon> = [
    { id: 1, name: 'bulbasaur', type: ['grass', 'poison'] },
    { id: 2, name: 'ivysaur', type: ['grass', 'poison'] },
    { id: 3, name: 'venusaur', type: ['grass', 'poison'] },
    { id: 4, name: 'charmander', type: ['fire'] },
    { id: 5, name: 'charmeleon', type: ['fire'] },
    { id: 6, name: 'charizard', type: ['fire', 'flying'] },
];

export const Types: Array<string> = [
    'normal',
    'fire',
    'water',
    'electric',
    'grass',
    'ice',
    'fighting',
    'poison',
    'ground',
    'flying',
    'psychic',
    'bug',
    'rock',
    'ghost',
    'dragon',
    'dark',
    'steel',
    'fairy',
];

export const pokemonDataMock: Array<PokemonData> = [
    {
        pokemon: {
            pokemon_id: 2,
            pokdex_id: 2,
            pokemon_name: 'Ivysaur',
            species: 'Seed',
            height: 1,
            weight: 13,
            max_exp: 1059862,
            hp: 60,
            attack: 62,
            defense: 63,
            special_attack: 80,
            special_defense: 80,
            speed: 60,
            total: 405,
            description: 'A Grass/Poison type Pokémon introduced in Generation 1.',
            type: ['grass', 'poison'],
            abilities: [
                {
                    name: 'Overgrow',
                    hidden: false,
                    description:
                        "Increases the power of Grass-type moves by 50% when the ability-bearer's HP falls below a third of its maximum HP",
                },
                {
                    name: 'Chlorophyll',
                    hidden: true,
                    description: "Doubles the ability-bearer's Speed during bright sunshine.",
                },
            ],
            eggGroups: ['grass', 'monster'],
            levelUpMoves: [
                {
                    level: 1,
                    move: 'Tackle',
                    category: 'physical',
                    power: 40,
                    accuracy: 100,
                },
                {
                    level: 15,
                    move: 'Poison Powder',
                    category: 'status',
                    power: null,
                    accuracy: 75,
                },
                {
                    level: 50,
                    move: 'Solar Beam',
                    category: 'special',
                    power: 120,
                    accuracy: 100,
                },
            ],
            evolutionMoves: [],
            eggMoves: [
                {
                    move: 'Petal Dance',
                    category: 'special',
                    power: 120,
                    accuracy: 100,
                },
            ],
            tmMoves: [
                {
                    tm: 28,
                    move: 'Giga Drain',
                    category: 'special',
                    power: 75,
                    accuracy: 100,
                },
            ],
            trMoves: [
                {
                    tr: 0,
                    move: 'Swords Dance',
                    category: 'status',
                    power: null,
                    accuracy: null,
                },
            ],
        },
        evolutionTree: [
            {
                pokemon: 'Bulbasaur',
                evolved_pokemon: 'Ivysaur',
                level: 16,
                held_item: null,
                use_item: null,
                time: null,
                friendship: false,
                move: null,
                trade: false,
                other: null,
            },
            {
                pokemon: 'Ivysaur',
                evolved_pokemon: 'Venusaur',
                level: 32,
                held_item: null,
                use_item: null,
                time: null,
                friendship: false,
                move: null,
                trade: false,
                other: null,
            },
        ],
    },
];
