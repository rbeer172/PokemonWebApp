import { Update } from '../../reducers/moves';
import { AppDispatch } from '../../store';
import update from '../../../api/moves/updateMove';

const updateMove = (move: Move) => (dispatch: AppDispatch) =>
    update(move).then((data) => {
        dispatch(Update(data));
    });
export default updateMove;
