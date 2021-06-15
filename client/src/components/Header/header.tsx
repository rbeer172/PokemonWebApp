import React from 'react';
import { AppBar, Grid, Button, Typography } from '@material-ui/core';
import Autocomplete from '@material-ui/lab/Autocomplete';
import { map } from 'lodash/fp';
import { useHistory } from 'react-router-dom';
import { NavLink, Logo, SearchBox, FlexGrowDiv } from './styles';
import logo from '../../assets/pokeball.png';

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
    const pokemon = ['bulbasaur', 'ivysaur', 'venusaur'];
    return (
        <>
            <AppBar position="relative">
                <Grid
                    container
                    alignItems="center"
                    style={{ padding: '0px 20px 0px 20px' }}>
                    <FlexGrowDiv>
                        <NavLink onClick={goHome}>
                            <Logo src={logo} alt="logo" />
                            <Typography
                                variant="h6"
                                style={{ padding: '10px' }}>
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
                        onChange={(e, value, reason) =>
                            reason !== 'clear' ? alert(value) : false
                        }
                        options={map((name) => name, pokemon)}
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
