import { Update } from '../../reducers/pokemon';
import { AppDispatch } from '../../store';
import update from '../../../api/pokemon/update';

const updatePokemon = (pokemon: PokemonData) => (dispatch: AppDispatch) =>
    update(pokemon).then((data) => {
        dispatch(Update(data));
    });
export default updatePokemon;
