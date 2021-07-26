declare type Pokemon = {
    id: number;
    name: string;
    type: Array<string>;
};

declare type PokemonTypeEffectiveness = {
    attacking_type: string;
    multiplier: number;
};

declare type Ability = {
    name: string;
    hidden: boolean;
    description: string;
};

declare type Move = {
    level?: number;
    tm?: number | string | null;
    tr?: number | string | null;
    name: string;
    type: string;
    category: string;
    power: number | null | string;
    accuracy: number | null | string;
    pp: number;
    priority?: number;
    description: string;
};

declare type MoveProperties = {
    categories: Array<number>;
    powerValues: Array<number>;
    accuracyValues: Array<number>;
    ppValues: Array<number>;
};

declare type Evolution = {
    pokemon: string;
    evolved_pokemon: string;
    level: number | null;
    held_item: string | null;
    use_item: string | null;
    time: string | null;
    friendship: boolean;
    move: string | null;
    trade: boolean;
    other: string | null;
};

declare type PokemonData = {
    pokemon: {
        pokemon_id: number;
        pokdex_id: number;
        pokemon_name: string;
        species: string;
        height: number;
        weight: number;
        max_exp: number;
        hp: number;
        attack: number;
        defense: number;
        special_attack: number;
        special_defense: number;
        speed: number;
        total: number;
        description: string;
        type: Array<string>;
        abilities: Array<Ability>;
        eggGroups: Array<string>;
        levelUpMoves: Array<Move>;
        evolutionMoves: Array<Move>;
        eggMoves: Array<Move>;
        tmMoves: Array<Move>;
        trMoves: Array<Move>;
        effectiveness: Array<PokemonTypeEffectiveness>;
    };
    evolutionTree: Array<Evolution>;
};
