-- SCHEMA: pokemon_db
--DROP SCHEMA pokemon_db;
--CREATE SCHEMA pokemon_db;

DROP TABLE IF EXISTS pokemon_db.pokemon CASCADE;
DROP TABLE IF EXISTS pokemon_db.typing CASCADE;
DROP TABLE IF EXISTS pokemon_db.type_effectiveness CASCADE;
DROP TABLE IF EXISTS pokemon_db.abilities CASCADE;
DROP TABLE IF EXISTS pokemon_db.moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.tm CASCADE;
DROP TABLE IF EXISTS pokemon_db.tr CASCADE;
DROP TABLE IF EXISTS pokemon_db.items CASCADE;
DROP TABLE IF EXISTS pokemon_db.pokemon_types CASCADE;
DROP TABLE IF EXISTS pokemon_db.pokemon_stats CASCADE;
DROP TABLE IF EXISTS pokemon_db.pokemon_abilities CASCADE;
DROP TABLE IF EXISTS pokemon_db.evolution_learned_moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.levelup_learned_moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.egg_moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.tr_learned_moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.tm_learned_moves CASCADE;
DROP TABLE IF EXISTS pokemon_db.evolution_group CASCADE;
DROP TABLE IF EXISTS pokemon_db.pokemon_evolution CASCADE;
DROP TABLE IF EXISTS pokemon_db.power_values CASCADE;
DROP TABLE IF EXISTS pokemon_db.accuracy_values CASCADE;
DROP TABLE IF EXISTS pokemon_db.pp_values CASCADE;
DROP TABLE IF EXISTS pokemon_db.egg_groups CASCADE;
DROP TABLE IF EXISTS pokemon_db.pokemon_egg_group CASCADE;
DROP TABLE IF EXISTS pokemon_db.type_categories CASCADE;

CREATE TABLE pokemon_db.power_values(power int PRIMARY KEY);
CREATE TABLE pokemon_db.accuracy_values(accuracy int PRIMARY KEY);
CREATE TABLE pokemon_db.pp_values(pp int PRIMARY KEY);
CREATE TABLE pokemon_db.type_categories(category varchar(10) PRIMARY KEY);

CREATE TABLE pokemon_db.pokemon(
    pokemon_id serial PRIMARY KEY,
    pokedex_id int NOT NULL,
    pokemon_name varchar(20) NOT NULL,
    species varchar(20) NOT NULL,
    height float NOT NULL,
    weight float NOT NULL,
    growth_rate varchar(10) NOT NULL,
    description text NOT NULL,
    hp int NOT NULL,
    attack int NOT NULL,
    defense int NOT NULL,
    special_attack int NOT NULL,
    special_defense int NOT NULL,
    speed int NOT NULL,
    total int NOT NULL
);

CREATE TABLE pokemon_db.typing(typing_name varchar(10) PRIMARY KEY);

CREATE TABLE pokemon_db.type_effectiveness(
    attacking_type varchar(10) NOT NULL,
    defending_type varchar(10) NOT NULL,
    multiplier FLOAT NOT NULL,
    CONSTRAINT attacking_type_fk FOREIGN KEY(attacking_type) REFERENCES pokemon_db.typing(typing_name),
    CONSTRAINT defending_type_fk FOREIGN KEY(defending_type) REFERENCES pokemon_db.typing(typing_name)
);

CREATE TABLE pokemon_db.abilities(
    ability_name varchar(20) PRIMARY KEY,
    description text NOT NULL
);

CREATE TABLE pokemon_db.moves(
    move_name varchar(20) PRIMARY KEY,
    typing varchar(10) NOT NULL,
    category varchar(10) NOT NULL,
    power int,
    accuracy int,
    pp int NOT NULL,
    priority int NOT NULL,
    description text NOT NULL,
    CONSTRAINT typing_fk FOREIGN KEY(typing) REFERENCES pokemon_db.typing(typing_name),
    CONSTRAINT power_fk FOREIGN KEY(power) REFERENCES pokemon_db.power_values(power),
    CONSTRAINT category_fk FOREIGN KEY(category) REFERENCES pokemon_db.type_categories(category),
    CONSTRAINT pp_fk FOREIGN KEY(pp) REFERENCES pokemon_db.pp_values(pp),
    CONSTRAINT accuracy_fk FOREIGN KEY(accuracy) REFERENCES pokemon_db.accuracy_values(accuracy)
);

CREATE TABLE pokemon_db.tm(
    tm_id int PRIMARY KEY,
    move_name varchar(20) NOT NULL,
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name)
);

CREATE TABLE pokemon_db.tr(
    tr_id int PRIMARY KEY,
    move_name varchar(20) NOT NULL,
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name)
);

CREATE TABLE pokemon_db.items(
    item_name varchar(20) PRIMARY KEY,
    description text NOT NULL
);

CREATE TABLE pokemon_db.egg_groups(group_name varchar(12) PRIMARY KEY);

CREATE TABLE pokemon_db.pokemon_egg_group(
    pokemon_id int NOT NULL,
    group_name varchar(12) NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT group_fk FOREIGN KEY(group_name) REFERENCES pokemon_db.egg_groups(group_name)
);

CREATE TABLE pokemon_db.pokemon_types(
    pokemon_id int NOT NULL,
    typing varchar(10) NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT typing_fk FOREIGN KEY(typing) REFERENCES pokemon_db.typing(typing_name)
);

CREATE TABLE pokemon_db.pokemon_abilities(
    pokemon_id int NOT NULL,
    ability_name varchar(20) NOT NULL,
    hidden bool NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT ability_name_fk FOREIGN KEY(ability_name) REFERENCES pokemon_db.abilities(ability_name)
);

CREATE TABLE pokemon_db.evolution_learned_moves(
    pokemon_id int NOT NULL,
    move_name varchar(20) NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name)
);

CREATE TABLE pokemon_db.levelup_learned_moves(
    pokemon_id int NOT NULL,
    move_name varchar(20) NOT NULL,
    LEVEL int NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name)
);

CREATE TABLE pokemon_db.egg_moves(
    pokemon_id int NOT NULL,
    move_name varchar(20) NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name)
);

CREATE TABLE pokemon_db.tr_learned_moves(
    pokemon_id int NOT NULL,
    move_name varchar(20) NOT NULL,
    tr_id int NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name),
    CONSTRAINT tr_id_fk FOREIGN KEY(tr_id) REFERENCES pokemon_db.tr(tr_id)
);

CREATE TABLE pokemon_db.tm_learned_moves(
    pokemon_id int NOT NULL,
    move_name varchar(20) NOT NULL,
    tm_id int NOT NULL,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name),
    CONSTRAINT tm_id_fk FOREIGN KEY(tm_id) REFERENCES pokemon_db.tm(tm_id)
);

CREATE TABLE pokemon_db.evolution_group(group_id serial PRIMARY KEY);

CREATE TABLE pokemon_db.pokemon_evolution(
    pokemon_id int NOT NULL,
    evolution_id int NOT NULL,
    evolution_order int NOT NULL,
    level int,
    held_item VARCHAR(20),
    use_item VARCHAR(20),
    day_time VARCHAR(10),
    friendship bool NOT NULL,
    move_name varchar(20),
    trade bool NOT NULL,
    other text,
    CONSTRAINT pokemon_id_fk FOREIGN KEY(pokemon_id) REFERENCES pokemon_db.pokemon(pokemon_id),
    CONSTRAINT evolution_id_fk FOREIGN KEY(evolution_id) REFERENCES pokemon_db.evolution_group(group_id),
    CONSTRAINT held_item_fk FOREIGN KEY(held_item) REFERENCES pokemon_db.items(item_name),
    CONSTRAINT use_item_fk FOREIGN KEY(use_item) REFERENCES pokemon_db.items(item_name),
    CONSTRAINT move_name_fk FOREIGN KEY(move_name) REFERENCES pokemon_db.moves(move_name),
    PRIMARY KEY(pokemon_id, evolution_id)
);