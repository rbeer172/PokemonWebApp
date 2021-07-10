import styled from 'styled-components';
import { Button, TextField, Grid, Typography } from '@material-ui/core';

export const Divider = styled.div`
    margin-top: 300px;
    padding-bottom: 100px;
`;

export const NavLink = styled(Button)`
    display: flex;
    flex-direction: row;
    align-items: center;

    color: white;
    text-decoration: none;

    &:hover {
        text-decoration: none;
    }

    &:not(:last-child) {
        margin-right: 1em;
    }
`;

export const Logo = styled.img`
    max-height: 64px;
`;

export const SearchBox = styled(TextField)`
    background: white;
    border-radius: 6px;
    width: 220px;
`;

export const FlexGrowDiv = styled.div`
    flex-grow: 1;
`;

export const HeaderGrid = styled(Grid).attrs({
    container: true,
    alignItems: 'center',
})`
    padding: 0px 20px 0px 20px;
`;

export const SiteName = styled(Typography).attrs({
    variant: 'h6',
})`
    padding: 10px;
`;
