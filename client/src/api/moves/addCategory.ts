import axios from '../axios';

export default (value: string) =>
    axios
        .post<Array<number>>(`/api/move/properties/category`, value)
        .then((response) => response.data);
