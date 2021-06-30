import React, { ReactElement } from 'react';
import { TableRow } from '@material-ui/core';
import { Key, Value } from './styles';

interface Props {
    name: string | ReactElement;
    value: string | number | Array<string> | (() => string | number) | ReactElement;
}

const RowPair = ({ name, value }: Props) => (
    <TableRow>
        <Key>{name}</Key>
        <Value>{typeof value === 'function' ? value() : value}</Value>
    </TableRow>
);

export default RowPair;
