import styled from 'styled-components';
import { TableCell, Typography, LinearProgress, TableSortLabel, Icon } from '@material-ui/core';
import { ArrowForward } from '@material-ui/icons';
import { ReactNode } from 'react';

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

const handleText = (child?: string | number | ReactNode) => {
    if (typeof child === 'string') {
        if (child.length > 20) return false;
    }
    if (typeof child === 'number') return true;
    return true;
};

const handleDirection = (direction?: 'up' | 'down' | 'straight') => {
    switch (direction) {
        case 'up':
            return `transform: rotate(-30deg);`;
        case 'down':
            return `transform: rotate(30deg);`;
        default:
            return ``;
    }
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
    padding: 'none',
})`
    text-transform: ${(props) => (handleText(props.children) ? 'capitalize' : 'none')};
    white-space: ${(props) => (handleText(props.children) ? 'nowrap' : 'normal')};
    text-align: ${(props) => (handleText(props.children) ? 'center' : 'start')};
    font-size: 16px;
    padding: 5px;
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell,
        'Open Sans', 'Helvetica Neue', sans-serif;
`;

export const SortHeader = styled(TableSortLabel).attrs({
    active: true,
})`
    margin-left: 15px;
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

export const TabContent = styled.div`
    width: 100%;
`;

export const Arrow = styled(Icon)<{ direction?: 'up' | 'down' | 'straight' }>`
    ${(props) => handleDirection(props.direction)};
    width: 80px;
    height: 40px;
    text-align: center;
`;

export const ForwardArrow = styled(ArrowForward)`
    font-size: 40px;
`;
