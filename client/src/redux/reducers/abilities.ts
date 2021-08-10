/* eslint-disable @typescript-eslint/no-unused-vars */
/* eslint-disable no-param-reassign */
import { createSlice, PayloadAction } from '@reduxjs/toolkit';

declare type Data = Array<Ability>;

const initialState: Data = [];

const slice = createSlice({
    name: 'Abilities',
    initialState,
    reducers: {
        Add: (state, { payload }: PayloadAction<Ability>) => {
            state.push(payload);
        },
        Delete: (state, { payload }: PayloadAction<string>) => {
            return state.filter((data) => data.ability_name !== payload);
        },
        AddMany: (state, { payload }: PayloadAction<Data>) => {
            payload.forEach((pokemon) => {
                state.push(pokemon);
            });
        },
        DeleteMany: (state, { payload }: PayloadAction<Array<string>>) => {
            return state.filter((data) => !payload.includes(data.ability_name));
        },
        DeleteAll: (state) => {
            state = [];
        },
        Update: (state, { payload }: PayloadAction<Ability>) => {
            return state.map((data) =>
                payload.ability_name === data.ability_name ? payload : data
            );
        },
    },
});

export const { Add, Delete, AddMany, DeleteMany, DeleteAll, Update } = slice.actions;
export default slice.reducer;
