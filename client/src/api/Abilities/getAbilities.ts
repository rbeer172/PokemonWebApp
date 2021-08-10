import axios from '../axios';

export default () => axios.get<Array<Ability>>(`/api/ability`).then((response) => response.data);
