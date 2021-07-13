import axios from '../axios';

export default (value: number) =>
    axios
        .post<Array<number>>(`/api/move/properties/power`, value)
        .then((response) => response.data);
