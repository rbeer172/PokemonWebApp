import React, { useState, useEffect } from 'react';
import { map, omit } from 'lodash/fp';
import { Button, Grid } from '@material-ui/core';
import { GridColumns, DataGrid } from '@material-ui/data-grid';
import { Color } from '@material-ui/lab';
import withKey from '../../utils/withKey';
import DynamicForm from '../../components/Form/DynamicForm';
import getAllWithMoves from '../../redux/thunks/pokemon/getAllPokemonWithMoves';
import useDispatchSelector from '../../hooks/useDispatchSelector';
import formComponents from './formComponents';
import useDispatchAction from '../../hooks/useDispatchAction';
import { useAppDispatch } from '../../hooks/reduxHooks';
import loadMoves from '../../redux/thunks/moves/loadMoves';
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
    const dispatch = useAppDispatch();
    const data: Array<PokemonList> = useDispatchSelector(getAllWithMoves, 'pokemon');
    useEffect(() => {
        dispatch(loadMoves());
    }, [dispatch]);

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
                    obj.levelUpMoves as Array<Ability>
                ),
            };
            return {
                id,
                ...newObj,
            };
        }, pokemonList);

    const submitNew = (formData: PokemonData) => {
        console.log(formData);
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
        console.log(formData);
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
            <Grid container spacing={2} direction="row">
                <Grid item xs={12}>
                    <DynamicForm
                        data={Selectedmove}
                        components={formComponents}
                        onSubmit={Selectedmove ? submitUpdate : submitNew}
                    />
                </Grid>
                <Grid item xs={6}>
                    <ObjectForm
                        form={formComponents}
                        data={abilities || []}
                        setData={setAbilities}
                        width={400}
                        columns={[
                            { field: 'ability', width: 200 },
                            { field: 'hidden', width: 200 },
                        ]}
                    />
                </Grid>
                <Grid item xs={6}>
                    <ObjectForm
                        form={formComponents}
                        data={levelMoves || []}
                        setData={setLevelMoves}
                        width={400}
                        columns={[
                            { field: 'name', width: 200 },
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
                        onClick={() => setSelectedmove(row)}>
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
                                console.log();
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