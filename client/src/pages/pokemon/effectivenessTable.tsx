import React from 'react';
import { map, chunk, sortBy, indexOf, flow } from 'lodash/fp';
import { Table, TableBody, TableRow, TableCell } from '@material-ui/core';
import Grid from '@material-ui/core/Grid';
import Typings from '../../components/typings';
import { TypeWeakness } from './styles';
import TableHeader from './tableHeader';
import { Types } from '../../types/mockData';

interface Props {
    data: PokemonData['pokemon'];
    columns: number;
}

const EffectivenessTable = ({ data, columns }: Props) => {
    const decimalToFraction = (number: number) => {
        switch (number) {
            case 0.25:
                return '1/4';
            case 0.5:
                return '1/2';
            default:
                return `${number}`;
        }
    };
    return (
        <Table style={{ width: 'fit-content' }}>
            <TableHeader name="Type Weakness" colSpan={columns} />
            <TableBody>
                {map(
                    (row: Array<PokemonTypeEffectiveness>) => (
                        <TableRow key={`${row[0].attacking_type}-outer`}>
                            {map(
                                (cell) => (
                                    <TableCell
                                        key={`${cell.attacking_type}-inner`}
                                        style={{ padding: '1px' }}>
                                        <Grid item>
                                            <Typings name={cell.attacking_type} size="small" />
                                        </Grid>
                                        <Grid item>
                                            <TypeWeakness multiplier={cell.multiplier}>
                                                {decimalToFraction(cell.multiplier)}
                                            </TypeWeakness>
                                        </Grid>
                                    </TableCell>
                                ),
                                row
                            )}
                        </TableRow>
                    ),
                    flow(
                        sortBy((obj: PokemonTypeEffectiveness) =>
                            indexOf(obj.attacking_type, Types)
                        ),
                        chunk(columns)
                    )(data.effectiveness)
                )}
            </TableBody>
        </Table>
    );
};

export default EffectivenessTable;
