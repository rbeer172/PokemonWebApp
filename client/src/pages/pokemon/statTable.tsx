import React from 'react';
import { Table, TableBody, TableRow, TableCell, Typography } from '@material-ui/core';
import { map, get } from 'lodash/fp';
import { Title, StatBar, Key } from './styles';
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
                            <TableCell width="6%">
                                <Typography align="center">{get(stat, data)}</Typography>
                            </TableCell>
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
                    <TableCell colSpan={2} padding="none">
                        <Title align="center" variant="h6">
                            {`Total: ${get('total', data)}`}
                        </Title>
                    </TableCell>
                </TableRow>
            </TableBody>
        </Table>
    );
};

export default StatTable;
