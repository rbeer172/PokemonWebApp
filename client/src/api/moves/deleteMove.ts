import axios from '../axios';

export default (move: string) =>
    axios.delete<Move>(`/api/moves/${move}`).then((response) => response.data);
