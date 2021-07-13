import axios from '../axios';

export default (move: Move) =>
    axios.post<Move>(`/api/moves`, move).then((response) => response.data);
