import { TextField } from '@material-ui/core';
import selectObject from './selectObject';

export default {
    fields: {
        ability: {
            Component: selectObject,
            props: {
                label: 'Ability',
                reduxSelector: 'abilities',
                optionList: (ability: Ability) => ability.ability_name,
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
