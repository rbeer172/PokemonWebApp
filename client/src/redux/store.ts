import { configureStore } from '@reduxjs/toolkit';
import pokemonList from './reducers/pokemonList';

const store = configureStore({
    reducer: {
        pokemonList,
    },
});

export default store;
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
