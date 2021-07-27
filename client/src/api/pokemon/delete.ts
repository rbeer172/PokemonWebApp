import axios from '../axios';

export default (name: string) =>
    axios.delete<string>(`/api/pokemon/${name}`).then((response) => response.data);
