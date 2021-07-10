import axios from '../axios';

export default (pokedex_id: number) =>
    axios
        .get<Array<PokemonData>>(`/api/pokemon/evolution/${pokedex_id}`)
        .then((response) => response.data);
