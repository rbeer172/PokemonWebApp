import React, { useEffect, useState } from 'react';
import TextField from '@material-ui/core/TextField';
import Autocomplete from '@material-ui/lab/Autocomplete';
import getTypes from '../../api/types/getTypes';

const SelectMoves = ({
    name,
    multiSelect,
    ...props
}: {
    name: string;
    multiSelect: boolean;
    value: Array<string> | string;
    onChange: (value: unknown) => void;
    style: Record<string, unknown>;
}) => {
    const [optionList, setOptionList] = useState<Array<string>>([]);

    useEffect(() => {
        getTypes().then((list) => {
            setOptionList(list);
        });
    }, []);

    return (
        <Autocomplete
            multiple={multiSelect}
            onChange={(_e, data) => props.onChange(data)}
            value={props.value || (multiSelect ? [] : null)}
            options={optionList}
            disableCloseOnSelect
            getOptionLabel={(option: string) => option}
            renderInput={(params) => (
                <TextField
                    {...params}
                    style={props.style}
                    variant="standard"
                    label={name}
                    placeholder="Type"
                />
            )}
        />
    );
};
export default SelectMoves;
