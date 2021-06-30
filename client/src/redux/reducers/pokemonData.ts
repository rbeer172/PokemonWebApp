/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type Data = {
    [key: string]: PokemonData;
};

const initialState: Data = {};

const slice = createSlice({
    name: 'PokemonDataWithEvolution',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<PokemonData>) => {
            state[payload.pokemon.pokemon_name] = payload;
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            delete state[payload];
        },
        AddMany: (state, { payload }: PayloadAction<Array<PokemonData>>) => {
            payload.forEach((pokemon) => {
                state[pokemon.pokemon.pokemon_name] = pokemon;
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            payload.forEach((name) => {
                delete state[name];
            });
        },
        DeleteAll: (state) => {
            state = {};
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll } = slice.actions;
export default slice.reducer;
