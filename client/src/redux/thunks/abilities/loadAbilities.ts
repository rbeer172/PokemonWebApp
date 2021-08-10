import { AddMany } from '../../reducers/abilities';
import { AppDispatch } from '../../store';
import getAbilities from '../../../api/Abilities/getAbilities';

const loadAbilities = () => (dispatch: AppDispatch) =>
    getAbilities().then((data) => {
        dispatch(AddMany(data));
    });
export default loadAbilities;
