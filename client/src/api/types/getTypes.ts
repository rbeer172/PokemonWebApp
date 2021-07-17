import axios from '../axios';

export default () => axios.get<Array<string>>(`/api/types`).then((response) => response.data);
