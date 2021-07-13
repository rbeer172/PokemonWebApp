import axios from '../axios';

export default () => axios.get<Array<Move>>(`/api/moves`).then((response) => response.data);
