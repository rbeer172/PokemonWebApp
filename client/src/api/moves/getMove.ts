import axios from '../axios';

export default (name: string) =>
    axios.get<Move>(`/api/moves/${name}`).then((response) => response.data);
