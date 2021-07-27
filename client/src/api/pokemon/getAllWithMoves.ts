import axios from '../axios';

export default () => axios.get<Array<PokemonData>>(`/api/pokemon/all`).then((data) => data.data);
