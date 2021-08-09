import { TextField } from '@material-ui/core';
import SelectMoves from './selectMoves';

export default {
    fields: {
        move: {
            Component: SelectMoves,
            props: {
                name: 'move',
                multiSelect: false,
                style: { width: 250 },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
        level: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: 50 },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
    },
};
