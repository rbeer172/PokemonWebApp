import React from 'react';
import { Table, TableBody } from '@material-ui/core';
import { map } from 'lodash/fp';
import TableHeader from './tableHeader';
import RowPair from './rowPair';

const AbilityTable = ({ data }: { data: PokemonData['pokemon'] }) => {
    return (
        <Table size="small">
            <TableHeader name="Abilities" colSpan={2} />
            <TableBody>
                {map(
                    (ability) => (
                        <RowPair
                            name={
                                ability.hidden === true
                                    ? `${ability.name} (hidden):`
                                    : `${ability.name}:`
                            }
                            value={ability.description}
                        />
                    ),
                    data.abilities
                )}
            </TableBody>
        </Table>
    );
};

export default AbilityTable;
