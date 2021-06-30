import React from 'react';
import { map, chunk, sortBy, indexOf, flow } from 'lodash/fp';
import { Table, TableBody, TableRow, TableCell } from '@material-ui/core';
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
                    (row: any) => (
                        <TableRow>
                            {map(
                                (cell) => (
                                    <TableCell style={{ padding: '1px' }}>
                                        <TableRow>
                                            <Typings name={cell.attacking_type} size="small" />
                                        </TableRow>
                                        <TableRow>
                                            <TypeWeakness multiplier={cell.multiplier}>
                                                {decimalToFraction(cell.multiplier)}
                                            </TypeWeakness>
                                        </TableRow>
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
