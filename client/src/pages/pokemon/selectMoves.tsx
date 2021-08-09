import React from 'react';
import TextField from '@material-ui/core/TextField';
import Autocomplete from '@material-ui/lab/Autocomplete';
import { get, filter, isNull, map } from 'lodash/fp';
import { useAppSelector } from '../../hooks/reduxHooks';

const SelectMoves = ({
    name,
    filterBy = 'none',
    multiSelect,
    ...props
}: {
    name: string;
    filterBy: 'tm' | 'tr' | 'none';
    multiSelect: boolean;
    value: Array<string> | string;
    onChange: (value: unknown) => void;
}) => {
    const moves: Array<Move> = useAppSelector<any>(get('moves'));

    const filterMoves = () => {
        if (filterBy === 'tm') return filter((move: Move) => !isNull(move.tm), moves);
        if (filterBy === 'tr') return filter((move: Move) => !isNull(move.tr), moves);
        return moves;
    };

    return (
        <Autocomplete
            multiple={multiSelect}
            onChange={(_e, data) => props.onChange(data)}
            value={props.value || [] || ''}
            options={map((move) => move.name, filterMoves())}
            disableCloseOnSelect
            getOptionLabel={(option: string) => option}
            renderInput={(params) => (
                <TextField
                    {...params}
                    {...props}
                    variant="outlined"
                    label={name}
                    placeholder="Move"
                />
            )}
        />
    );
};
export default SelectMoves;
