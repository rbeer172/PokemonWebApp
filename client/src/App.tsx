import React from 'react';
import { Switch, Route } from 'react-router-dom';
import { Container, Paper, Box } from '@material-ui/core';
import { Provider } from 'react-redux';
import store from './redux/store';
import img from './assets/background.jpg';
import Header from './components/Header/header';
import Home from './pages/home';
import Pokedex from './pages/pokedex';

const App = () => {
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
                }}>
                <Container
                    component={Paper}
                    maxWidth="lg"
                    style={{
                        flexDirection: 'column',
                        padding: '0',
                    }}>
                    <Header />
                    <Box padding="20px">
                        <Switch>
                            <Route exact path="/" component={Home} />
                            <Route exact path="/pokedex" component={Pokedex} />
                        </Switch>
                    </Box>
                </Container>
            </div>
        </Provider>
    );
};
export default App;
