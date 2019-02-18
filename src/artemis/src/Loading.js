import React from 'react'
import { Grid, CircularProgress } from '@material-ui/core';

const Loading = () => (
  <Grid container justify="center">
    <Grid item>
      <CircularProgress />
    </Grid>
  </Grid>
)

export default Loading