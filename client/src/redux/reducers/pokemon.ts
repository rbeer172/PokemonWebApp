/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type Data = Array<PokemonData>;

const initialState: Data = [];

const slice = createSlice({
    name: 'Pokemon',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<PokemonData>) => {
            state.push(payload);
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            return state.filter((data) => data.pokemon.pokemon_name !== payload);
        },
        AddMany: (state, { payload }: PayloadAction<Data>) => {
            payload.forEach((pokemon) => {
                state.push(pokemon);
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            return state.filter((data) => !payload.includes(data.pokemon.pokemon_name));
        },
        DeleteAll: (state) => {
            state = [];
        },
        Update: (state, { payload }: PayloadAction<PokemonData>) => {
            return state.map((data) =>
                payload.pokemon.pokemon_name === data.pokemon.pokemon_name ? payload : data
            );
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll, Update } = slice.actions;
export default slice.reducer;
