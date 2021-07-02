import React from 'react';
import { useParams } from 'react-router-dom';
import Grid from '@material-ui/core/Grid';
import { Typography } from '@material-ui/core';
import useGetPokemon from '../../hooks/useGetPokemonData';
import DexTable from './dexTable';
import EffectivenessTable from './effectivenessTable';
import StatTable from './statTable';
import AbilityTable from './abilityTable';
import MoveTables from './moveTables';

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
                <Grid item xs={4} style={{ minWidth: 'max-content' }}>
                    <img
                        src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/${data.pokemon.pokdex_id}.png`}
                        alt="pokemon"
                        width="400px"
                        height="400px"
                    />
                </Grid>
                <Grid container item xs={8}>
                    <Grid container item>
                        <Grid container item xs={12}>
                            <DexTable data={data.pokemon} />
                        </Grid>
                        <Grid container item xs={12}>
                            <AbilityTable data={data.pokemon} />
                        </Grid>
                    </Grid>
                </Grid>
                <Grid container item xs={7}>
                    <StatTable data={data.pokemon} />
                </Grid>
                <Grid container item xs={5} justify="center">
                    <EffectivenessTable data={data.pokemon} columns={6} />
                </Grid>
                <Grid container item xs={12} justify="center">
                    <MoveTables data={data.pokemon} />
                </Grid>
            </Grid>
        </>
    ) : (
        <></>
    );
};

export default Pokemon;
