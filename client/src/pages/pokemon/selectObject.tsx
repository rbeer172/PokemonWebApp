import React from 'react';
import TextField from '@material-ui/core/TextField';
import Autocomplete from '@material-ui/lab/Autocomplete';
import { get, map } from 'lodash/fp';
import { useAppSelector } from '../../hooks/reduxHooks';

type ObjectList = Array<Record<string, unknown>>;

const SelectObject = ({
    label,
    multiSelect,
    optionList,
    reduxSelector,
    ...props
}: {
    label: string;
    multiSelect: boolean;
    value: Array<string> | string;
    onChange: (value: unknown) => void;
    optionList: (value: Record<string, unknown>) => string;
    reduxSelector: string;
}) => {
    const list: ObjectList = useAppSelector<ObjectList>(get(reduxSelector));

    return (
        <Autocomplete
            multiple={multiSelect}
            onChange={(_e, data) => props.onChange(data)}
            value={props.value || (multiSelect ? [] : null)}
            options={map(optionList, list)}
            disableCloseOnSelect
            getOptionLabel={(option: string) => option}
            renderInput={(params) => (
                <TextField
                    {...params}
                    {...props}
                    variant="outlined"
                    label={label}
                    placeholder={label}
                />
            )}
        />
    );
};
export default SelectObject;
