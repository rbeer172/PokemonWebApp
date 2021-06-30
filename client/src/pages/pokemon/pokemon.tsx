import React from 'react';
import { useParams } from 'react-router-dom';
import Grid from '@material-ui/core/Grid';
import { Typography, Table, TableBody, TableRow } from '@material-ui/core';
import useGetPokemon from '../../hooks/useGetPokemonData';
import DexTable from './dexTable';
import EffectivenessTable from './effectivenessTable';
import StatTable from './statTable';
import AbilityTable from './abilityTable';

const Pokemon = () => {
    const { name } = useParams<{ name: string }>();
    const data: PokemonData = useGetPokemon(name);
    return data !== undefined ? (
        <>
            <Typography align="center" variant="h3">
                {data.pokemon.pokemon_name}
            </Typography>
            <Typography align="center" variant="h6">
                {data.pokemon.description}
            </Typography>
            <Grid container item spacing={0} direction="row" alignItems="center">
                <Grid item xs={3}>
                    <img
                        src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/${data.pokemon.pokdex_id}.png`}
                        alt="pokemon"
                        width="350px"
                        height="350px"
                    />
                </Grid>
                <Grid container item xs={9}>
                    <Table style={{ marginLeft: '40px' }}>
                        <TableBody>
                            <TableRow>
                                <DexTable data={data.pokemon} />
                            </TableRow>
                            <TableRow>
                                <AbilityTable data={data.pokemon} />
                            </TableRow>
                        </TableBody>
                    </Table>
                </Grid>
                <Grid container item xs={7}>
                    <StatTable data={data.pokemon} />
                </Grid>
                <Grid container item xs={5} justify="center">
                    <EffectivenessTable data={data.pokemon} columns={6} />
                </Grid>
            </Grid>
        </>
    ) : (
        <></>
    );
};

export default Pokemon;
