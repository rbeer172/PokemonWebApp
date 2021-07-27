import axios from '../axios';

export default () => axios.get<Array<Pokemon>>(`/api/pokemon`).then((data) => data.data);
