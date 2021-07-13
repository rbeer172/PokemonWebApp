import axios from '../axios';

export default () =>
    axios.get<MoveProperties>(`/api/move/properties`).then((response) => response.data);
