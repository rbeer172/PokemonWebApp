import axios from '../axios';

export default (pokemon: PokemonData) =>
    axios.post<PokemonData>(`/api/pokemon/update`, pokemon).then((response) => response.data);
