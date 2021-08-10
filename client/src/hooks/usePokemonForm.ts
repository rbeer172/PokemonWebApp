/* eslint-disable @typescript-eslint/no-explicit-any */
import { useEffect } from 'react';
import { get } from 'lodash/fp';
import { batch } from 'react-redux';
import { useAppDispatch, useAppSelector } from './reduxHooks';
import getAllWithMoves from '../redux/thunks/pokemon/getAllPokemonWithMoves';
import loadMoves from '../redux/thunks/moves/loadMoves';
import loadAbilities from '../redux/thunks/abilities/loadAbilities';

const useDispatchAction = () => {
    const dispatch = useAppDispatch();

    useEffect(() => {
        batch(() => {
            dispatch(getAllWithMoves());
            dispatch(loadMoves());
            dispatch(loadAbilities());
        });
    }, [dispatch]);

    return useAppSelector<Array<PokemonList>>(get('pokemon'));
};
export default useDispatchAction;
