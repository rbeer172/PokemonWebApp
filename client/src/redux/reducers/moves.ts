/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type Data = Array<Move>;

const initialState: Data = [];

const slice = createSlice({
    name: 'Moves',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<Move>) => {
            state.push(payload);
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            return state.filter((move) => move.name !== payload);
        },
        AddMany: (state, { payload }: PayloadAction<Data>) => {
            payload.forEach((pokemon) => {
                state.push(pokemon);
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            return state.filter((move) => !payload.includes(move.name));
        },
        DeleteAll: (state) => {
            state = [];
        },
        Update: (state, { payload }: PayloadAction<Move>) => {
            return state.map((move) => (payload.name === move.name ? payload : move));
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll, Update } = slice.actions;
export default slice.reducer;
