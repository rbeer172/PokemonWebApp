import { AddMany } from '../../reducers/pokemon';
import { AppDispatch } from '../../store';
import getAllWithMoves from '../../../api/pokemon/getAllWithMoves';

const getAllPokemonWithMoves = () => (dispatch: AppDispatch) =>
    getAllWithMoves().then((data) => {
        dispatch(AddMany(data));
    });
export default getAllPokemonWithMoves;
