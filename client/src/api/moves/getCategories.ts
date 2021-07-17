import axios from '../axios';

export default () =>
    axios.get<Array<string>>(`/api/moves/properties/category`).then((response) => response.data);
