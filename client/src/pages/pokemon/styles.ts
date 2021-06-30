/* eslint-disable import/prefer-default-export */
import styled from 'styled-components';
import { TableCell, Typography, LinearProgress } from '@material-ui/core';

const handleWeakness = (weakness?: number) => {
    switch (weakness) {
        case 0.25:
            return `#10a0a0`;
        case 0.5:
            return `#4ee221`;
        case 2:
            return `#ff5926de`;
        case 4:
            return `#ff2828de`;
        default:
            return `#424242`;
    }
};

const statBarColor = (stat: number) => {
    if (stat <= 50) return `#c52929`;
    if (stat > 50 && stat < 80) return `#c8d414`;
    if (stat >= 80 && stat < 120) return `#4ee221`;
    if (stat >= 120) return `#10a0a0`;
    return 'gray';
};

export const Key = styled(TableCell).attrs({
    size: 'small',
    padding: 'none',
})`
    font-weight: bold;
    text-transform: capitalize;
    font-size: 18px;
    padding-top: 7px;
    padding-bottom: 7px;
    white-space: nowrap;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell,
        'Open Sans', 'Helvetica Neue', sans-serif;
`;

export const Value = styled(TableCell).attrs({
    size: 'small',
})`
    font-size: 16px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell,
        'Open Sans', 'Helvetica Neue', sans-serif;
`;

export const Cell = styled(TableCell).attrs({
    size: 'small',
    align: 'center',
})`
    font-size: 16px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell,
        'Open Sans', 'Helvetica Neue', sans-serif;
`;

export const TypeWeakness = styled(Typography)<{ multiplier?: number }>`
    background-color: ${(props) => handleWeakness(props.multiplier)};
    border: 1px solid black;
    border-radius: 3px;
    text-align: center;
`;

export const Title = styled(Typography)`
    font-weight: bold;
    text-transform: capitalize;
    text-align: center;
`;

export const StatBar = styled(LinearProgress)<{ stat: number }>`
    border-radius: 5px;
    background-color: gray;
    height: 12px;
    .MuiLinearProgress-barColorPrimary {
        background-color: ${(props) => statBarColor(props.stat)};
    }
`;
