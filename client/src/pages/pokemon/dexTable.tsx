import React from 'react';
import { map } from 'lodash/fp';
import Grid from '@material-ui/core/Grid';
import { Table, TableBody, TableRow, TableCell } from '@material-ui/core';
import Typings from '../../components/typings';
import { Cell } from './styles';
import TableHeader from './tableHeader';

const DexTable = ({ data }: { data: PokemonData['pokemon'] }) => {
    const names = [
        'Pokedex',
        'Species',
        'Type',
        'Height',
        'Weight',
        'Max Experience',
        'Egg Groups',
    ];
    const formatId = (id: number) => {
        if (id < 10) return `00${id}`;
        if (id < 100) return `0${id}`;
        return `${id}`;
    };
    const numWithCommas = (x: number) => x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ',');
    return (
        <Table size="small">
            <TableHeader columns={names} />
            <TableBody>
                <TableRow>
                    <Cell>{formatId(data.pokdex_id)}</Cell>
                    <Cell>{`${data.species} Pokemon`}</Cell>
                    <TableCell size="small">
                        <Grid container item direction="row">
                            {map(
                                (type) => (
                                    <Grid container item xs={6} key={type}>
                                        <Typings name={type} />
                                    </Grid>
                                ),
                                data.type
                            )}
                        </Grid>
                    </TableCell>
                    <Cell>{`${data.height} m`}</Cell>
                    <Cell>{`${data.weight} kg`}</Cell>
                    <Cell>{numWithCommas(data.max_exp)}</Cell>
                    <Cell>
                        <Grid container item direction="row" spacing={1}>
                            {map(
                                (group) => (
                                    <Grid container item xs={6} key={group}>
                                        {group}
                                    </Grid>
                                ),
                                data.eggGroups
                            )}
                        </Grid>
                    </Cell>
                </TableRow>
            </TableBody>
        </Table>
    );
};

export default DexTable;
