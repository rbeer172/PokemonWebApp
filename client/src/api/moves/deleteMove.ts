import axios from '../axios';

export default (move: string) =>
    axios.delete<string>(`/api/moves/${move}`).then((response) => response.data);
