import React, { useState } from 'react';
import { AppBar, Tabs, Tab } from '@material-ui/core';
import SortedTable from './sortedTable';
import { Title, TabContent } from './styles';

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
            <TabContent hidden={value !== 0}>
                <SortedTable data={data.levelUpMoves} />
            </TabContent>
            <TabContent hidden={value !== 1}>
                <SortedTable data={data.tmMoves} />
            </TabContent>
            <TabContent hidden={value !== 2}>
                <SortedTable data={data.trMoves} />
            </TabContent>
            <TabContent hidden={value !== 3}>
                <SortedTable data={data.eggMoves} />
            </TabContent>
            <TabContent hidden={value !== 4}>
                <SortedTable data={data.evolutionMoves} />
            </TabContent>
        </>
    );
};
export default MoveTables;
