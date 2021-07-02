import React, { useState } from 'react';
import { map, keys, orderBy, flow, isUndefined } from 'lodash/fp';
import { Table, TableBody, TableRow, TableHead } from '@material-ui/core';
import Typings from '../../components/typings';
import withKey from '../../utils/withKey';
import { Cell, Key, Title, SortHeader } from './styles';

type Value = string | number | null;

interface Props {
    name?: string;
    data: Array<Record<string, Value>>;
}

const SortedTable = ({ name, data }: Props) => {
    const keyList = keys(data[0]);
    const [moves, setMoves] = useState(orderBy(keyList[0], 'asc', data));
    const [sortedKey, setSortedKey] = useState(keyList[0]);

    const handleSort = (key: string, order: 'asc' | 'desc') => {
        flow(orderBy(key, order), setMoves)(data);
        setSortedKey(key);
    };
    return (
        <Table>
            <TableHead>
                {isUndefined(name) ? (
                    <></>
                ) : (
                    <TableRow>
                        <Cell key={name} colSpan={keyList.length}>
                            <Title variant="h5">{name}</Title>
                        </Cell>
                    </TableRow>
                )}
                <TableRow>
                    {map(
                        (cell) => (
                            <Key key={cell} align="center">
                                <SortHeader
                                    direction={sortedKey === cell ? 'asc' : 'desc'}
                                    onClick={() =>
                                        handleSort(cell, sortedKey === cell ? 'desc' : 'asc')
                                    }>
                                    {cell}
                                </SortHeader>
                            </Key>
                        ),
                        keyList
                    )}
                </TableRow>
            </TableHead>
            <TableBody>
                {withKey(map)(
                    (row: Record<string, Value>, outerKey: string) => (
                        <TableRow key={`${outerKey}-outer`}>
                            {withKey(map)(
                                (value: string | number, innerKey: string) => (
                                    <Cell key={`${innerKey}-inner`}>
                                        {innerKey === 'type' ? (
                                            <Typings name={value as string} size="small" />
                                        ) : (
                                            value
                                        )}
                                    </Cell>
                                ),
                                row
                            )}
                        </TableRow>
                    ),
                    moves
                )}
            </TableBody>
        </Table>
    );
};

export default SortedTable;
