/* eslint-disable @typescript-eslint/no-explicit-any */
import { useEffect } from 'react';
import { get } from 'lodash/fp';
import { useAppDispatch, useAppSelector } from './reduxHooks';

const useDispatchAction = (
    action: any,
    id: string | number,
    search?: string | number
) => {
    const dispatch = useAppDispatch();

    useEffect(() => {
        dispatch(action(search));
    }, [search, action, dispatch]);

    return useAppSelector(get(id));
};
export default useDispatchAction;
