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
        hidden: {
            Component: TextField,
            props: {
                type: 'checkbox',
                style: { width: 200 },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
    },
};
