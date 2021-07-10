import React, { ReactElement } from 'react';
import { Grid, Typography } from '@material-ui/core';
import { map, get, reduce } from 'lodash/fp';
import { useAppSelector } from '../../hooks/reduxHooks';
import PokemonCard from '../../components/pokemonCard';
import withKey from '../../utils/withKey';
import { Arrow, ForwardArrow } from './styles';
import buildTree from '../../utils/buildTree';

interface Node {
    name: string;
    data: Evolution | null;
}
type Type = string | number | boolean | null;

const EvolutionTree = ({ data }: { data: Array<Evolution> }) => {
    const pokemonList = useAppSelector(get('pokemonList[Pokemon]'));
    const tree = buildTree(data);

    const arrowDirection = (current: Node, index: number, ListIndex: number) => {
        const list = get(ListIndex, tree);
        const prevList = get(ListIndex - 1, tree);

        if (prevList !== undefined) {
            for (let k = 0; k < prevList.length; k += 1) {
                if (prevList[k].name === current.data?.pokemon && list.length > prevList.length) {
                    if (index <= list.length / 2 - 1) {
                        return (
                            <Arrow direction="up">
                                <ForwardArrow />
                            </Arrow>
                        );
                    }
                    if (index > list.length / 2 - 1) {
                        return (
                            <Arrow direction="down">
                                <ForwardArrow />
                            </Arrow>
                        );
                    }
                } else
                    return (
                        <Arrow>
                            <ForwardArrow />
                        </Arrow>
                    );
            }
        }
        return '';
    };

    const displayData = (list: Array<ReactElement>, value: Type, key: string) => {
        if (value !== null && value !== false && key !== 'pokemon' && key !== 'evolved_pokemon')
            list.push(<Typography key={key}>{`${key}: ${value}`}</Typography>);
        return list;
    };

    return (
        <Grid container item justify="center" direction="row" style={{ marginLeft: '-120px' }}>
            {withKey(map)(
                (evolutionList: Array<Node>, i: number) => (
                    <Grid container item xs={3} key={i}>
                        {withKey(map)((evolution: Node, j: number) => {
                            return (
                                <React.Fragment key={evolution.name}>
                                    <Grid
                                        container
                                        item
                                        xs={5}
                                        justify="center"
                                        alignContent="center">
                                        {arrowDirection(evolution, j, i)}
                                        {withKey(reduce)(displayData, [], evolution.data)}
                                    </Grid>
                                    <Grid container item xs={7} justify="center">
                                        <PokemonCard data={get(evolution.name, pokemonList)} />
                                    </Grid>
                                </React.Fragment>
                            );
                        }, evolutionList)}
                    </Grid>
                ),
                tree
            )}
        </Grid>
    );
};
export default EvolutionTree;
