import { TextField } from '@material-ui/core';
import SelectMoves from './selectMoves';

export default {
    fields: {
        move: {
            Component: SelectMoves,
            props: {
                name: 'move',
                multiSelect: false,
                style: { width: 300 },
            },
            grid: {
                xs: 8,
                justify: 'center',
            },
        },
        level: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: 120 },
            },
            grid: {
                xs: 4,
                justify: 'center',
            },
        },
    },
};
