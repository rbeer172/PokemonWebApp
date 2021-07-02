import React, { useState } from 'react';
import { AppBar, Tabs, Tab } from '@material-ui/core';
import SortedTable from './sortedTable';
import { Title } from './styles';

const MoveTables = ({ data }: { data: PokemonData['pokemon'] }) => {
    const [value, setValue] = useState(0);

    const handleChange = (newValue: number) => {
        setValue(newValue);
    };

    return (
        <>
            <Title variant="h5">Moves</Title>
            <AppBar position="static" color="default">
                <Tabs centered value={value} onChange={(event, id) => handleChange(id)}>
                    <Tab label="Level Up" />
                    <Tab label="Tm" />
                    <Tab label="Tr" />
                    <Tab label="Egg Moves" />
                    <Tab label="Evolution" />
                </Tabs>
            </AppBar>
            <div hidden={value !== 0} style={{ width: '100%' }}>
                <SortedTable data={data.levelUpMoves} />
            </div>
            <div hidden={value !== 1} style={{ width: '100%' }}>
                <SortedTable data={data.tmMoves} />
            </div>
            <div hidden={value !== 2} style={{ width: '100%' }}>
                <SortedTable data={data.trMoves} />
            </div>
            <div hidden={value !== 3} style={{ width: '100%' }}>
                <SortedTable data={data.eggMoves} />
            </div>
            <div hidden={value !== 4} style={{ width: '100%' }}>
                <SortedTable data={data.evolutionMoves} />
            </div>
        </>
    );
};
export default MoveTables;
