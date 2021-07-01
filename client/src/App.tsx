import React from 'react';
import { Switch, Route } from 'react-router-dom';
import { Container, Paper, Box, createMuiTheme } from '@material-ui/core';
import { ThemeProvider } from '@material-ui/styles';
import { Provider } from 'react-redux';
import store from './redux/store';
import img from './assets/background.jpg';
import Header from './components/Header/header';
import Home from './pages/home';
import Pokedex from './pages/pokedex';
import Pokemon from './pages/pokemon';

const App = () => {
    const theme = createMuiTheme({
        palette: {
            type: 'dark',
        },
    });
    return (
        <Provider store={store}>
            <div
                style={{
                    backgroundImage: `url(${img})`,
                    position: 'fixed',
                    top: '0',
                    width: '100%',
                    height: '100%',
                    left: '0',
                    backgroundSize: 'cover',
                    overflowY: 'scroll',
                }}>
                <Container component={Paper} maxWidth="lg" style={{ padding: '0' }}>
                    <Header />
                    <ThemeProvider theme={theme}>
                        <Box padding="20px">
                            <Switch>
                                <Route exact path="/" component={Home} />
                                <Route exact path="/pokedex" component={Pokedex} />
                                <Route exact path="/pokedex/:name" component={Pokemon} />
                            </Switch>
                        </Box>
                    </ThemeProvider>
                </Container>
            </div>
        </Provider>
    );
};
export default App;
