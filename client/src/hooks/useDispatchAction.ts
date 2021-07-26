/* eslint-disable @typescript-eslint/no-explicit-any */
import { useAppDispatch } from './reduxHooks';

const useDispatchAction = (action: any) => {
    const dispatch = useAppDispatch();

    return (data: string | number | Record<string, any> | undefined): Promise<any> =>
        dispatch(action(data));
};
export default useDispatchAction;
