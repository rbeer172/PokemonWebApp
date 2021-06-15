import React from 'react';
import { CardActionArea, CardMedia } from '@material-ui/core';
import Grid from '@material-ui/core/Grid';
import { NavLink } from 'react-router-dom';
import { map } from 'lodash/fp';
import { Title, StyledCard } from './styles';
import Typings from '../typings';

const PokemonCard = ({ data }: { data: Pokemon }) => (
    <StyledCard>
        <CardActionArea>
            <NavLink to={`/pokedex/${data.Name}`}>
                <CardMedia
                    component="img"
                    src={`https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/${data.Id}.png`}
                    title="pokemon"
                />
                <Title variant="h6">{data.Name}</Title>
            </NavLink>
        </CardActionArea>
        <Grid container item direction="row" spacing={1}>
            {map(
                (type) => (
                    <Grid
                        container
                        item
                        xs={data.Type.length === 1 ? 12 : 6}
                        justify="center">
                        <Typings name={type} />
                    </Grid>
                ),
                data.Type
            )}
        </Grid>
    </StyledCard>
);
export default PokemonCard;
