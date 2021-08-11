import React, { useState } from 'react';
import { map, omit } from 'lodash/fp';
import { Button, Grid } from '@material-ui/core';
import { GridColumns, DataGrid } from '@material-ui/data-grid';
import { Color } from '@material-ui/lab';
import withKey from '../../utils/withKey';
import DynamicForm from '../../components/Form/DynamicForm';
import formComponents from './formComponents';
import abilityForm from './abilityForm';
import levelMovesForm from './levelMovesForm';
import usePokemonForm from '../../hooks/usePokemonForm';
import useDispatchAction from '../../hooks/useDispatchAction';
import createPokemon from '../../redux/thunks/pokemon/addPokemon';
import updatePokemon from '../../redux/thunks/pokemon/updatePokemon';
import deletePokemon from '../../redux/thunks/pokemon/deletePokemon';
import SnackBarAlert from '../../components/snackBar/snackBarAlert';
import ObjectForm from './objectForm';

type LevelMove = {
    level: number;
    move: string;
};
type NewAbility = {
    ability: string;
    hidden: boolean;
};

const Moves = () => {
    const data: Array<PokemonList> = usePokemonForm();

    const [Selectedmove, setSelectedmove] = useState<PokemonList | undefined>(undefined);
    const [message, setMessage] = useState('');
    const [severity, setSeverity] = useState<Color>('success');
    const [open, setOpen] = useState(false);
    const [levelMoves, setLevelMoves] = useState<Array<LevelMove> | undefined>(undefined);
    const [abilities, setAbilities] = useState<Array<NewAbility> | undefined>(undefined);

    const create = useDispatchAction(createPokemon);
    const update = useDispatchAction(updatePokemon);
    const Delete = useDispatchAction(deletePokemon);

    let row: PokemonList | undefined;

    const columns: GridColumns = [
        { field: 'pokemon_id', width: 70, type: 'number' },
        { field: 'pokdex_id', width: 70, type: 'number' },
        { field: 'pokemon_name', width: 100 },
        { field: 'type', width: 120 },
        { field: 'species', width: 80 },
        { field: 'height', width: 80, type: 'number' },
        { field: 'weight', width: 80, type: 'number' },
        { field: 'max_exp', width: 90, type: 'number' },
        { field: 'eggGroups', width: 130 },
        { field: 'hp', width: 80, type: 'number' },
        { field: 'attack', width: 80, type: 'number' },
        { field: 'defense', width: 80, type: 'number' },
        { field: 'special_attack', width: 80, type: 'number' },
        { field: 'special_defense', width: 80, type: 'number' },
        { field: 'speed', width: 80, type: 'number' },
        { field: 'total', width: 80, type: 'number' },
    ];

    const getRows = (pokemonList: Array<PokemonList>): GridColumns =>
        withKey(map)((obj: PokemonList, id: number) => {
            const newObj: PokemonList = {
                ...obj,
                evolutionMoves: map((move) => move.move, obj.evolutionMoves as Array<Move>),
                eggMoves: map((move) => move.move, obj.eggMoves as Array<Move>),
                tmMoves: map((move) => move.move, obj.tmMoves as Array<Move>),
                trMoves: map((move) => move.move, obj.trMoves as Array<Move>),
                levelUpMoves: map(
                    (move) => ({ move: move.move, level: move.level }),
                    obj.levelUpMoves as Array<Move>
                ),
                abilities: map(
                    (ability) => ({ ability: ability.name, hidden: ability.hidden }),
                    obj.abilities as Array<PokemonAbility>
                ),
            };
            return {
                id,
                ...newObj,
            };
        }, pokemonList);

    const submitNew = (formData: PokemonData) => {
        console.log({ ...formData, abilities, levelMoves });
        // create(formData)
        //     .then(() => {
        //         setSeverity('success');
        //         setMessage('Move Added');
        //         setOpen(true);
        //     })
        //     .catch((e) => {
        //         setSeverity('error');
        //         setMessage(e.message);
        //         setOpen(true);
        //     })
        //     .finally(() => {
        //         setSelectedmove(undefined);
        //     });
    };

    const submitUpdate = (formData: PokemonData) => {
        console.log({ ...formData, abilities, levelMoves });
        setAbilities(undefined);
        setLevelMoves(undefined);
        // update(formData)
        //     .then(() => {
        //         setSeverity('success');
        //         setMessage('Move Updated');
        //         setOpen(true);
        //     })
        //     .catch((e) => {
        //         setSeverity('error');
        //         setMessage(e.message);
        //         setOpen(true);
        //     })
        //     .finally(() => {
        //         setSelectedmove(undefined);
        //     });
    };
    return (
        <>
            <SnackBarAlert open={open} setOpen={setOpen} severity={severity} message={message} />
            <Grid container spacing={4} direction="row">
                <Grid item xs={12}>
                    <DynamicForm
                        data={Selectedmove}
                        components={formComponents}
                        onSubmit={Selectedmove ? submitUpdate : submitNew}
                    />
                </Grid>
                <Grid item xs={6}>
                    <ObjectForm
                        form={abilityForm}
                        data={abilities || []}
                        setData={setAbilities}
                        name="Abilities"
                        columns={[
                            { field: 'ability', width: 200 },
                            { field: 'hidden', width: 200 },
                        ]}
                    />
                </Grid>
                <Grid item xs={6}>
                    <ObjectForm
                        form={levelMovesForm}
                        data={levelMoves || []}
                        setData={setLevelMoves}
                        name="Level Up Moves"
                        columns={[
                            { field: 'move', width: 200 },
                            { field: 'level', width: 200 },
                        ]}
                    />
                </Grid>
                <Grid item style={{ height: 600 }} xs={12}>
                    <DataGrid
                        disableColumnMenu
                        columns={columns}
                        rows={getRows(data)}
                        onRowClick={(params) => {
                            const pokemon: PokemonList = omit(
                                ['id', 'pokemon_id'],
                                params.row
                            ) as PokemonList;
                            row = pokemon;
                            console.log('row', row);
                        }}
                    />
                </Grid>
                <Grid item container xs={6} justify="flex-end">
                    <Button
                        type="submit"
                        variant="contained"
                        color="primary"
                        onClick={() => {
                            setSelectedmove(row);
                            setAbilities(row?.abilities as Array<NewAbility>);
                            setLevelMoves(row?.levelUpMoves as Array<LevelMove>);
                        }}>
                        Update
                    </Button>
                </Grid>
                <Grid item container xs={6} justify="flex-start">
                    <Button
                        type="submit"
                        variant="contained"
                        color="primary"
                        onClick={
                            () => {
                                console.log('deleted');
                            }
                            // Delete(row?.pokemon.pokdex_id)
                            //     .then(() => {
                            //         setSeverity('success');
                            //         setMessage('Move Deleted');
                            //         setOpen(true);
                            //     })
                            //     .catch((e) => {
                            //         setSeverity('error');
                            //         setMessage(e.message);
                            //         setOpen(true);
                            //     })
                        }>
                        Delete
                    </Button>
                </Grid>
            </Grid>
        </>
    );
};
export default Moves;
