import React, { useCallback, useEffect } from 'react';
import Grid from '@material-ui/core/Grid';
import { useForm, Controller } from 'react-hook-form';
import { ValidatorForm } from 'react-material-ui-form-validator';
import { Button } from '@material-ui/core';
import { map } from 'lodash/fp';
import withKey from '../../utils/withKey';

type Fields = {
    Component: React.ComponentType | React.ElementType;
    props?: Record<string, unknown>;
    grid?: Record<string, unknown>;
};

type Form = Record<'fields', Record<string, Fields>>;

interface Props {
    components: Form;
    data?: { [key: string]: unknown };
    onSubmit: (...args: any[]) => void;
}

const DynamicForm = ({ components, data, onSubmit }: Props) => {
    const { control, handleSubmit, reset } = useForm();

    useEffect(() => {
        reset({ ...data });
    }, [data, reset]);

    const submission = useCallback(
        (formData: { [key: string]: unknown }) => {
            onSubmit(formData);
            reset({});
        },
        [onSubmit, reset]
    );

    return (
        <ValidatorForm onSubmit={handleSubmit(submission)}>
            <Grid container spacing={3}>
                {withKey(map)(
                    (field: Fields, key: string) => (
                        <Controller
                            name={key}
                            key={key}
                            defaultValue={data ? data[key] : ''}
                            control={control}
                            render={(props) => (
                                <Grid container item {...field.grid}>
                                    {field.Component ? (
                                        <field.Component
                                            label={key}
                                            {...props.field}
                                            {...field.props}
                                        />
                                    ) : (
                                        false
                                    )}
                                </Grid>
                            )}
                        />
                    ),
                    components.fields
                )}
            </Grid>
            <Grid
                container
                direction="row"
                justify="center"
                alignItems="flex-end"
                style={{ padding: '20px' }}>
                <Button type="submit" variant="contained" color="primary">
                    Save
                </Button>
            </Grid>
        </ValidatorForm>
    );
};

export default DynamicForm;
