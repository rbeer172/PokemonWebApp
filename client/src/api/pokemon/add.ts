import axios from '../axios';

export default (pokemon: PokemonData) =>
    axios.post<PokemonData>(`/api/pokemon`, pokemon).then((response) => response.data);
