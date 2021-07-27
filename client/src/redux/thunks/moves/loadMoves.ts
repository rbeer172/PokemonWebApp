import { AddMany } from '../../reducers/moves';
import { AppDispatch } from '../../store';
import getAllMoves from '../../../api/moves/getAllMoves';

const loadMoves = () => (dispatch: AppDispatch) =>
    getAllMoves().then((data) => {
        dispatch(AddMany(data));
    });
export default loadMoves;
