import styled from 'styled-components';
import { Typography, Card } from '@material-ui/core';

export const Title = styled(Typography)`
    font-weight: bold;
    text-transform: capitalize;
    text-align: center;
`;

export const StyledCard = styled(Card)`
    padding: 10px;
    min-width: 130px;
    background-color: gray;
`;
