/* eslint-disable @typescript-eslint/no-explicit-any */
import { useEffect } from 'react';
// import { ThunkAction, AnyAction } from '@reduxjs/toolkit';
import { get } from 'lodash/fp';
import { useAppDispatch, useAppSelector } from './reduxHooks';
// import { RootState } from '../redux/store';

const useDispatchAction = (
    action: any,
    id: string | number,
    search?: string | number
) => {
    const dispatch = useAppDispatch();

    useEffect(() => {
        dispatch(action(search));
    }, [action, dispatch, search]);

    return useAppSelector(get(id));
};
export default useDispatchAction;
