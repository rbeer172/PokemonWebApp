/* eslint-disable @typescript-eslint/no-explicit-any */
import { get } from 'lodash/fp';
import { useEffect } from 'react';
import { useAppDispatch, useAppSelector } from './reduxHooks';
import loadPokemonData from '../redux/thunks/loadPokemonData';

const useGetPokemonData = (name: string | number) => {
    const dispatch = useAppDispatch();
    const id: number = useAppSelector(get(`pokemonList[Pokemon][${name}][id]`));
    useEffect(() => {
        dispatch(loadPokemonData(id));
    }, [dispatch, id]);
    const pokemon: PokemonData = useAppSelector(get(`pokemonData[${name}]`));
    return pokemon;
};
export default useGetPokemonData;
