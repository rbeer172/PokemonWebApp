import React, { useState, useEffect } from 'react';
import { MenuItem, TextField } from '@material-ui/core';
import { map } from 'lodash/fp';

type ApiFunction = () => Promise<Array<string> | Array<number>>;
type List = Array<string> | Array<number>;
interface Props {
    data: ApiFunction;
    isNullable: boolean;
}

const SelectMenu = ({ data, isNullable = false, ...props }: Props) => {
    const [optionList, setOptionList] = useState<List>();

    useEffect(() => {
        data().then((list) => {
            setOptionList(list);
        });
    }, [data]);

    return (
        <TextField select {...props}>
            {isNullable ? (
                <MenuItem key="null-key" value={undefined}>
                    -
                </MenuItem>
            ) : (
                false
            )}
            {map(
                (element) => (
                    <MenuItem key={element as string} value={element as string | number}>
                        {element}
                    </MenuItem>
                ),
                optionList
            )}
        </TextField>
    );
};
export default SelectMenu;
