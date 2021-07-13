import axios from '../axios';

export default (move: Move) =>
    axios.post<Move>(`/api/moves/update`, move).then((response) => response.data);
