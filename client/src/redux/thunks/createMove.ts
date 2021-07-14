import { Add } from '../reducers/moves';
import { AppDispatch } from '../store';
import addMove from '../../api/moves/addMove';

const createMove = (move: Move) => (dispatch: AppDispatch) =>
    addMove(move).then((data) => {
        dispatch(Add(data));
    });
export default createMove;
