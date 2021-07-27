import { Delete } from '../../reducers/moves';
import { AppDispatch } from '../../store';
import delete_move from '../../../api/moves/deleteMove';

const deleteMove = (name: string) => (dispatch: AppDispatch) =>
    delete_move(name).then((move) => {
        dispatch(Delete(move));
    });
export default deleteMove;
