import React from 'react';
import Grid from '@material-ui/core/Grid';
import { map } from 'lodash/fp';
import PokemonCard from '../../components/pokemonCard';
import loadPokemonList from '../../redux/thunks/loadPokemonList';
import useDispatchSelector from '../../hooks/useDispatchSelector';

const Pokedex = () => {
    // const pokemon: Array<Pokemon> = [
    //     { Id: 1, Name: 'bulbasaur', Type: ['grass', 'poison'] },
    //     { Id: 2, Name: 'ivysaur', Type: ['grass', 'poison'] },
    //     { Id: 3, Name: 'venusaur', Type: ['grass', 'poison'] },
    //     { Id: 4, Name: 'charmander', Type: ['fire'] },
    //     { Id: 5, Name: 'charmeleon', Type: ['fire'] },
    //     { Id: 6, Name: 'charizard', Type: ['fire', 'flying'] },
    // ];
    const list = useDispatchSelector(loadPokemonList, 'PokemonList');
    return (
        <Grid container item spacing={6}>
            {map(
                (data) => (
                    <Grid
                        container
                        item
                        xs={2}
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
