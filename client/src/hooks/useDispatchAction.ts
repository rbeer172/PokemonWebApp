/* eslint-disable @typescript-eslint/no-explicit-any */
import { useCallback } from 'react';
import { useAppDispatch } from './reduxHooks';

const useDispatchAction = (action: any) => {
    const dispatch = useAppDispatch();

    return useCallback(
        (data) => {
            dispatch(action(data));
        },
        [action, dispatch]
    );
};
export default useDispatchAction;
