import { Add } from '../../reducers/pokemon';
import { AppDispatch } from '../../store';
import add from '../../../api/pokemon/add';

const addPokemon = (pokemon: PokemonData) => (dispatch: AppDispatch) =>
    add(pokemon).then((data) => {
        dispatch(Add(data));
    });
export default addPokemon;
