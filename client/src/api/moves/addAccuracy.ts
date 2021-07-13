import axios from '../axios';

export default (value: number) =>
    axios
        .post<Array<number>>(`/api/move/properties/accuracy`, value)
        .then((response) => response.data);
