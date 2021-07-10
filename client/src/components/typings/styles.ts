import styled from 'styled-components';
import { Box } from '@material-ui/core';

const handleSize = (size?: string) => {
    switch (size) {
        case 'normal':
            return `    
                padding: 5px;
                width: 62px;
                font-size: 13px;`;
        case 'small':
            return `    
                padding: 5px;
                width: 55px;
                font-size: 11px;`;
        default:
            return `    
                padding: 5px;
                width: 62px;
                font-size: 13px;`;
    }
};

export const Type = styled(Box)<{ size?: string }>`
    background-color: ${(props) => props.color};
    text-align: center;
    text-transform: uppercase;
    color: white;
    font-weight: bold;
    ${(props) => handleSize(props.size)};
    font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell,
        'Open Sans', 'Helvetica Neue', sans-serif;
`;
