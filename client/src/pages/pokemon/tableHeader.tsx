import React from 'react';
import { TableRow, TableCell, TableHead, Padding } from '@material-ui/core';
import { map, isArray, keys, isUndefined } from 'lodash/fp';
import { Title, Key } from './styles';

interface Props {
    name?: string;
    columns?: Array<string> | { [key: string]: string };
    colSpan?: number;
    padding?: Padding;
}

const TableHeader = ({ name, columns, colSpan, padding }: Props) => (
    <TableHead>
        {isUndefined(name) ? (
            <></>
        ) : (
            <TableRow>
                <TableCell key={name} colSpan={colSpan} padding={padding}>
                    <Title variant="h5">{name}</Title>
                </TableCell>
            </TableRow>
        )}
        {isUndefined(columns) ? (
            <></>
        ) : (
            <TableRow>
                {map(
                    (element: string) => (
                        <Key key={element} align="center">
                            {element}
                        </Key>
                    ),
                    isArray(columns) ? columns : keys(columns)
                )}
            </TableRow>
        )}
    </TableHead>
);
export default TableHeader;
