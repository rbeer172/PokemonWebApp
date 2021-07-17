import axios from '../axios';

export default () =>
    axios.get<Array<number>>(`/api/moves/properties/power`).then((response) => response.data);
