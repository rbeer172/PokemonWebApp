import { TextField } from '@material-ui/core';
import SelectMoves from './selectMoves';
import SelectType from './selectType';

export default {
    fields: {
        pokdex_id: {
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
        pokemon_name: {
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
            Component: SelectType,
            props: {
                name: 'type',
                multiSelect: true,
                style: { width: '350px' },
            },
            grid: {
                xs: 4,
                justify: 'center',
            },
        },
        species: {
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
        height: {
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
        weight: {
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
        max_exp: {
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
        hp: {
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
        attack: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        defense: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        special_attack: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        special_defense: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        speed: {
            Component: TextField,
            props: {
                type: 'number',
                style: { width: '150px' },
            },
            grid: {
                xs: 2,
                justify: 'center',
            },
        },
        total: {
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
        evolutionMoves: {
            Component: SelectMoves,
            props: {
                name: 'evolutionMoves',
                multiSelect: true,
                style: { width: '550px' },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
        eggMoves: {
            Component: SelectMoves,
            props: {
                name: 'eggMoves',
                multiSelect: true,
                style: { width: '550px' },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
        tmMoves: {
            Component: SelectMoves,
            props: {
                name: 'tmMoves',
                multiSelect: true,
                filterBy: 'tm',
                style: { width: '550px' },
            },
            grid: {
                xs: 6,
                justify: 'center',
            },
        },
        trMoves: {
            Component: SelectMoves,
            props: {
                name: 'trMoves',
                multiSelect: true,
                filterBy: 'tr',
                style: { width: '550px' },
            },
            grid: {
                xs: 6,
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
