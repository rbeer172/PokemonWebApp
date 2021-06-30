import React from 'react';
import Grid from '@material-ui/core/Grid';
import { map, get } from 'lodash/fp';
import PokemonCard from '../../components/pokemonCard';
import { useAppSelector } from '../../hooks/reduxHooks';

const Pokedex = () => {
    const list = useAppSelector(get('pokemonList[Pokemon]'));
    return (
        <Grid container item spacing={6}>
            {map(
                (data) => (
                    <Grid
                        container
                        item
                        xs={2}
                        key={data.name}
                        alignItems="center"
                        direction="column">
                        <PokemonCard data={data} />
                    </Grid>
                ),
                list
            )}
        </Grid>
    );
};
export default Pokedex;
