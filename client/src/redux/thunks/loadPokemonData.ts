import { AddMany } from '../reducers/pokemonData';
import { AppDispatch } from '../store';
import getPokemonById from '../../api/pokemonData/getPokemonById';

const loadPokemonData = (pokedex_id: number) => (dispatch: AppDispatch) =>
    getPokemonById(pokedex_id).then((data) => {
        dispatch(AddMany(data));
    });
export default loadPokemonData;
