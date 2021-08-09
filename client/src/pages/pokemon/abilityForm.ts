import { TextField } from '@material-ui/core';
import SelectAbilities from './selectAbilities';

export default {
    fields: {
        ability: {
            Component: SelectAbilities,
            props: {
                name: 'ability',
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
