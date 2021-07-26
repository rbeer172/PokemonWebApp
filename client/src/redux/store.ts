import { configureStore } from '@reduxjs/toolkit';
import pokemonList from './reducers/pokemonList';
import pokemonData from './reducers/pokemonData';
import moves from './reducers/moves';

const store = configureStore({
    reducer: {
        pokemonList,
        pokemonData,
        moves,
    },
});

export default store;
export type RootState = ReturnType<typeof store.getState>;
export type AppDispatch = typeof store.dispatch;
