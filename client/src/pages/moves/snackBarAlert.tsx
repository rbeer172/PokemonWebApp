import React from 'react';
import { Snackbar } from '@material-ui/core';
import MuiAlert, { Color } from '@material-ui/lab/Alert';

interface Props {
    open: boolean;
    setOpen: (open: boolean) => void;
    severity?: Color;
    message?: string;
}

const SnackBarAlert = ({ open, setOpen, severity, message }: Props) => {
    const handleClose = (event?: React.SyntheticEvent, reason?: string) => {
        if (reason === 'clickaway') return;
        setOpen(false);
    };

    return (
        <Snackbar
            anchorOrigin={{ vertical: 'top', horizontal: 'center' }}
            open={open}
            autoHideDuration={3000}
            onClose={handleClose}>
            <MuiAlert variant="filled" onClose={handleClose} severity={severity}>
                {message}
            </MuiAlert>
        </Snackbar>
    );
};
export default SnackBarAlert;
