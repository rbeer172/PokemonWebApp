import React from 'react';
import { Table, TableBody, TableRow } from '@material-ui/core';
import { map } from 'lodash/fp';
import TableHeader from './tableHeader';
import { Key, Value } from './styles';

const AbilityTable = ({ data }: { data: PokemonData['pokemon'] }) => {
    return (
        <Table size="small">
            <TableHeader name="Abilities" colSpan={2} />
            <TableBody key="ability">
                {map(
                    (ability) => (
                        <TableRow>
                            <Key>
                                {ability.hidden === true
                                    ? `${ability.name} (hidden):`
                                    : `${ability.name}:`}
                            </Key>
                            <Value>{ability.description}</Value>
                        </TableRow>
                    ),
                    data.abilities
                )}
            </TableBody>
        </Table>
    );
};

export default AbilityTable;
