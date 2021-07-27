import { Delete } from '../../reducers/pokemon';
import { AppDispatch } from '../../store';
import deleteEntity from '../../../api/pokemon/delete';

const deletePokemon = (name: string) => (dispatch: AppDispatch) =>
    deleteEntity(name).then((data) => {
        dispatch(Delete(data));
    });
export default deletePokemon;
