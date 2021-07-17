import axios from '../axios';

export default () =>
    axios.get<Array<string>>(`/api/moves/properties/accuracy`).then((response) => response.data);
