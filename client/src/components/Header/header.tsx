import React from 'react';
import { AppBar, Grid, Button, Typography } from '@material-ui/core';
import Autocomplete from '@material-ui/lab/Autocomplete';
import { map } from 'lodash/fp';
import { useHistory } from 'react-router-dom';
import { NavLink, Logo, SearchBox, FlexGrowDiv } from './styles';
import logo from '../../assets/pokeball.png';
import loadPokemonList from '../../redux/thunks/loadPokemonList';
import useDispatchSelector from '../../hooks/useDispatchSelector';

// <TextField {...params} label="freeSolo" margin="normal" variant="outlined" />
/* <div ref={params.InputProps.ref}>
    <input placeholder="Search..." type="text"
    style={{borderRadius: 6,
        position: 'relative',
        fontSize: 16,
        height: '30px'}}
    {...params.inputProps}/>
    </div> */

const Header = () => {
    const history = useHistory();
    const goHome = () => history.push('/');
    const goToPokedex = () => history.push('/pokedex');
    const goToPokemonPage = (name: string | null) => history.push(`/pokedex/${name}`);
    const list = useDispatchSelector(loadPokemonList, 'pokemonList[Pokemon]');
    return (
        <>
            <AppBar position="relative">
                <Grid container alignItems="center" style={{ padding: '0px 20px 0px 20px' }}>
                    <FlexGrowDiv>
                        <NavLink onClick={goHome}>
                            <Logo src={logo} alt="logo" />
                            <Typography variant="h6" style={{ padding: '10px' }}>
                                Pokemon App
                            </Typography>
                        </NavLink>
                    </FlexGrowDiv>
                    <Button color="inherit" onClick={goToPokedex}>
                        Pokedex
                    </Button>
                    <Button color="inherit">Team Builder</Button>
                    <Button color="inherit">Damage Calculator</Button>
                    <Autocomplete
                        id="free-solo-demo"
                        freeSolo
                        size="small"
                        onChange={(e, value: string | null, reason) =>
                            reason !== 'clear' ? goToPokemonPage(value) : false
                        }
                        options={map((pokemon) => pokemon.name, list)}
                        renderInput={(params) => (
                            <SearchBox
                                {...params}
                                label="Search..."
                                margin="dense"
                                variant="outlined"
                            />
                        )}
                    />
                </Grid>
            </AppBar>
        </>
    );
};

export default Header;
