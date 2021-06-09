import React from 'react';
import { Switch, Route } from 'react-router-dom';
import { Container, Paper } from '@material-ui/core';
import img from './assets/background.jpg';
import Header from './Header/header';
import Home from './pages/home';

const App = () => {
    return (
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
                    background: 'grey',
                    border: '2px solid black',
                    padding: '0',
                }}>
                <Header />
                <Switch>
                    <Route exact path="/" component={Home} />
                </Switch>
            </Container>
        </div>
    );
};
export default App;
