import React, { useState } from 'react';
import { map, omit, mapValues, isNull, toInteger, isString } from 'lodash/fp';
import { Button, Grid } from '@material-ui/core';
import { GridColumns, DataGrid, GridColTypeDef } from '@material-ui/data-grid';
import { Color } from '@material-ui/lab';
import withKey from '../../utils/withKey';
import DynamicForm from '../../components/Form/DynamicForm';
import loadMoves from '../../redux/thunks/moves/loadMoves';
import useDispatchSelector from '../../hooks/useDispatchSelector';
import ExpandCell from './expandCell';
import formComponents from './formComponents';
import useDispatchAction from '../../hooks/useDispatchAction';
import createMove from '../../redux/thunks/moves/createMove';
import updateMove from '../../redux/thunks/moves/updateMove';
import deleteMove from '../../redux/thunks/moves/deleteMove';
import SnackBarAlert from '../../components/snackBar/snackBarAlert';

const Moves = () => {
    const data: Array<Move> = useDispatchSelector(loadMoves, 'moves');
    const [Selectedmove, setSelectedmove] = useState<Move | undefined>(undefined);
    const [message, setMessage] = useState('');
    const [severity, setSeverity] = useState<Color>('success');
    const [open, setOpen] = useState(false);

    const create = useDispatchAction(createMove);
    const update = useDispatchAction(updateMove);
    const Delete = useDispatchAction(deleteMove);

    let row: Move | undefined;

    const num: GridColTypeDef = {
        type: 'number',
        valueFormatter: ({ value }) => (value === -1 ? '-' : value),
    };

    const columns: GridColumns = [
        { field: 'name', width: 150 },
        { field: 'type', width: 85 },
        { field: 'category', width: 90 },
        { field: 'power', width: 95, ...num },
        { field: 'accuracy', width: 95, ...num },
        { field: 'pp', width: 75, ...num },
        { field: 'priority', width: 100, ...num },
        { field: 'tm', width: 72, ...num },
        { field: 'tr', width: 70, ...num },
        { field: 'description', flex: 1, renderCell: ExpandCell },
    ];

    const getRows = (moves: Array<Move>): GridColumns =>
        withKey(map)((move: Move, id: number) => {
            return {
                id,
                ...mapValues((value) => (isNull(value) ? -1 : value), move),
            };
        }, moves);

    const formatMove = (move: Move) =>
        mapValues((value) => {
            if (value === '' || value === undefined) return null;
            if (isString(value)) {
                if (value.match(/^-?\d+$/)) return toInteger(value);
            }
            return value;
        }, move) as Move;

    const submitNew = (formData: Move) => {
        create(formatMove(formData))
            .then(() => {
                setSeverity('success');
                setMessage('Move Added');
                setOpen(true);
            })
            .catch((e) => {
                setSeverity('error');
                setMessage(e.message);
                setOpen(true);
            })
            .finally(() => {
                setSelectedmove(undefined);
            });
    };

    const submitUpdate = (formData: Move) => {
        update(formatMove(formData))
            .then(() => {
                setSeverity('success');
                setMessage('Move Updated');
                setOpen(true);
            })
            .catch((e) => {
                setSeverity('error');
                setMessage(e.message);
                setOpen(true);
            })
            .finally(() => {
                setSelectedmove(undefined);
            });
    };
    return (
        <>
            <SnackBarAlert open={open} setOpen={setOpen} severity={severity} message={message} />
            <Grid container spacing={2} direction="row">
                <Grid item xs={12}>
                    <DynamicForm
                        data={Selectedmove}
                        components={formComponents}
                        onSubmit={Selectedmove ? submitUpdate : submitNew}
                    />
                </Grid>
                <Grid item style={{ height: 600 }} xs={12}>
                    <DataGrid
                        disableColumnMenu
                        columns={columns}
                        rows={getRows(data)}
                        onRowClick={(params) => {
                            const move: Move = omit(['id'], params.row) as Move;

                            const newmove = mapValues(
                                (value) => (value === -1 ? null : value),
                                move
                            );
                            row = newmove as Move;
                        }}
                    />
                </Grid>
                <Grid item container xs={6} justify="flex-end">
                    <Button
                        type="submit"
                        variant="contained"
                        color="primary"
                        onClick={() => setSelectedmove(row)}>
                        Update
                    </Button>
                </Grid>
                <Grid item container xs={6} justify="flex-start">
                    <Button
                        type="submit"
                        variant="contained"
                        color="primary"
                        onClick={() =>
                            Delete(row?.name)
                                .then(() => {
                                    setSeverity('success');
                                    setMessage('Move Deleted');
                                    setOpen(true);
                                })
                                .catch((e) => {
                                    setSeverity('error');
                                    setMessage(e.message);
                                    setOpen(true);
                                })
                        }>
                        Delete
                    </Button>
                </Grid>
            </Grid>
        </>
    );
};
export default Moves;
