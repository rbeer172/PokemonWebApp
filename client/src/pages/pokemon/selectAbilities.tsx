import React from 'react';
import TextField from '@material-ui/core/TextField';
import Autocomplete from '@material-ui/lab/Autocomplete';
import { get, map } from 'lodash/fp';
import { useAppSelector } from '../../hooks/reduxHooks';

const SelectAbilities = ({
    name,
    multiSelect,
    ...props
}: {
    name: string;
    multiSelect: boolean;
    value: Array<string> | string;
    onChange: (value: unknown) => void;
}) => {
    const abilities: Array<Ability> = useAppSelector<any>(get('abilities'));

    return (
        <Autocomplete
            multiple={multiSelect}
            onChange={(_e, data) => props.onChange(data)}
            value={props.value || [] || ''}
            options={map((ability) => ability.name, abilities)}
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
export default SelectAbilities;
