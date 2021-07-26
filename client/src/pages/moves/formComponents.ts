import { TextField } from '@material-ui/core';
import SelectMenu from './selectMenu';
import getAccuracy from '../../api/moves/getAccuracy';
import getCategories from '../../api/moves/getCategories';
import getPP from '../../api/moves/getPP';
import getPower from '../../api/moves/getPower';
import getTypes from '../../api/types/getTypes';

export default {
    fields: {
        name: {
            Component: TextField,
            props: {
                type: 'text',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        type: {
            Component: SelectMenu,
            props: {
                data: getTypes,
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        category: {
            Component: SelectMenu,
            props: {
                data: getCategories,
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        power: {
            Component: SelectMenu,
            props: {
                data: getPower,
                isNullable: true,
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        accuracy: {
            Component: SelectMenu,
            props: {
                data: getAccuracy,
                isNullable: true,
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        pp: {
            Component: SelectMenu,
            props: {
                data: getPP,
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        priority: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        tm: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        tr: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 1,
                justify: 'center',
            },
        },
        description: {
            Component: TextField,
            props: {
                type: 'text',
                multiline: true,
                rows: 3,
                variant: 'outlined',
                style: { width: '100%' },
            },
            grid: {
                xs: 12,
                justify: 'center',
            },
        },
    },
};
