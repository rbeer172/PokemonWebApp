import React from 'react';
import { map, omit, filter, isEqual } from 'lodash/fp';
import { Button, Grid, Typography } from '@material-ui/core';
import { GridColumns, DataGrid } from '@material-ui/data-grid';
import withKey from '../../utils/withKey';
import DynamicForm from '../../components/Form/DynamicForm';
import { GridForm } from './styles';

type Obj = Record<string, unknown>;
type ObjectList = Array<Obj>;

type Fields = {
    Component: React.ComponentType | React.ElementType;
    props?: Record<string, unknown>;
    grid?: Record<string, unknown>;
};

type Form = Record<'fields', Record<string, Fields>>;

interface Props {
    data: ObjectList;
    setData: React.Dispatch<React.SetStateAction<Array<any> | undefined>>;
    name: string;
    columns: GridColumns;
    form: Form;
}

const ObjectForm = ({ data, setData, columns, form, name }: Props) => {
    let row: Obj | undefined;

    const getRows = (list: ObjectList): GridColumns =>
        withKey(map)((obj: Obj, id: number) => ({ id, ...obj }), list);

    const submitNew = (formData: Obj) => {
        setData([...data, formData]);
    };

    return (
        <>
            <GridForm container spacing={2} direction="row">
                <Grid item xs={12}>
                    <Typography variant="h5" align="center">
                        {name}
                    </Typography>
                </Grid>
                <Grid item xs={12}>
                    <DynamicForm components={form} onSubmit={submitNew} />
                </Grid>
                <Grid item style={{ height: 300 }} xs={12}>
                    <DataGrid
                        disableColumnMenu
                        rowsPerPageOptions={[]}
                        columns={columns}
                        rows={getRows(data)}
                        onRowClick={(params) => {
                            const obj: Obj = omit(['id'], params.row) as Obj;
                            row = obj;
                        }}
                    />
                </Grid>
                <Grid item container xs={12} justify="center">
                    <Button
                        type="submit"
                        variant="contained"
                        color="primary"
                        onClick={() => {
                            setData(filter((obj: Obj) => !isEqual(obj, row), data));
                            row = undefined;
                        }}>
                        Delete
                    </Button>
                </Grid>
            </GridForm>
        </>
    );
};
export default ObjectForm;
