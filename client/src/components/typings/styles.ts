/* eslint-disable import/prefer-default-export */
import styled from 'styled-components';
import { Box } from '@material-ui/core';

export const Type = styled(Box)`
    background-color: ${(props) => props.color};
    padding: 5px;
    width: 62px;
    text-align: center;
    text-transform: uppercase;
    color: white;
    font-size: 13px;
`;
