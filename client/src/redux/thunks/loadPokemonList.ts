import { AddMany } from '../reducers/pokemonList';
import { AppDispatch } from '../store';
import getList from '../../api/pokemonList/getList';

const loadPokemonList = () => (dispatch: AppDispatch) =>
    getList().then((data) => {
        dispatch(AddMany(data));
    });
export default loadPokemonList;
