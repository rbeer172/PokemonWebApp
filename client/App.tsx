import React from 'react';
import { Container, Paper } from '@material-ui/core';
import img from './src/assets/background.jpg';
import Header from './src/Header/header';

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
                padding: '20px',
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
                <h1>Pokemon App</h1>
            </Container>
        </div>
    );
};
export default App;
