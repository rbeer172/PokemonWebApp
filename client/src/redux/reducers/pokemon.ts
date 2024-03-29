/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type Data = Array<PokemonList>;

const initialState: Data = [];

const slice = createSlice({
    name: 'Pokemon',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<PokemonList>) => {
            state.push(payload);
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            return state.filter((data) => data.pokemon_name !== payload);
        },
        AddMany: (state, { payload }: PayloadAction<Data>) => {
            payload.forEach((pokemon) => {
                state.push(pokemon);
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            return state.filter((data) => !payload.includes(data.pokemon_name));
        },
        DeleteAll: (state) => {
            state = [];
        },
        Update: (state, { payload }: PayloadAction<PokemonList>) => {
            return state.map((data) =>
                payload.pokemon_name === data.pokemon_name ? payload : data
            );
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll, Update } = slice.actions;
export default slice.reducer;
