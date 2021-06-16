/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type PokemonList = {
    Pokemon: {
        [key: string]: Pokemon;
    };
};

const initialState: PokemonList = { Pokemon: {} };

const slice = createSlice({
    name: 'PokemonList',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<Pokemon>) => {
            state.Pokemon[payload.name] = payload;
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            delete state.Pokemon[payload];
        },
        AddMany: (state, { payload }: PayloadAction<Array<Pokemon>>) => {
            payload.forEach((pokemon) => {
                state.Pokemon[pokemon.name] = pokemon;
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            payload.forEach((name) => {
                delete state.Pokemon[name];
            });
        },
        DeleteAll: (state) => {
            state.Pokemon = {};
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll } = slice.actions;
export default slice.reducer;
