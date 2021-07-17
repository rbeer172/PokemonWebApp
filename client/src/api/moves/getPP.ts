import axios from '../axios';

export default () =>
    axios.get<Array<number>>(`/api/moves/properties/pp`).then((response) => response.data);
