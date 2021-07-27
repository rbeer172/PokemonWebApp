import axios from '../axios';

export default () => axios.get<Array<Pokemon>>(`/api/pokemon/all`).then((data) => data.data);
