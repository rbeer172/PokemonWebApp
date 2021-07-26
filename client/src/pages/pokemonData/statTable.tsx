import React from 'react';
import { Table, TableBody, TableRow, TableCell } from '@material-ui/core';
import { map, get } from 'lodash/fp';
import { StatBar, Key, Cell } from './styles';
import TableHeader from './tableHeader';

const StatTable = ({ data }: { data: PokemonData['pokemon'] }) => {
    const stats = ['hp', 'attack', 'defense', 'special_attack', 'special_defense', 'speed'];
    const normalise = (value: number) => (value * 100) / 255;
    return (
        <Table size="small">
            <TableHeader name="Base Stats" colSpan={3} padding="none" />
            <TableBody>
                {map(
                    (stat) => (
                        <TableRow key={stat}>
                            <Key align="right" width="22%">
                                {stat.replace('_', ' ')}
                            </Key>
                            <Cell width="6%">{get(stat, data)}</Cell>
                            <TableCell>
                                <StatBar
                                    variant="determinate"
                                    stat={get(stat, data)}
                                    value={normalise(get(stat, data))}
                                />
                            </TableCell>
                        </TableRow>
                    ),
                    stats
                )}
                <TableRow>
                    <Key align="center" colSpan={2}>{`Total: ${get('total', data)}`}</Key>
                </TableRow>
            </TableBody>
        </Table>
    );
};

export default StatTable;
