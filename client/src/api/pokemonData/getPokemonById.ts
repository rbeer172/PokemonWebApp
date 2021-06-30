import axios from '../axios';

export default (pokedex_id: number) =>
    axios.get<Array<PokemonData>>(`/api/pokemon/${pokedex_id}`).then((response) => response.data);
