import React from 'react'
import { Grid, Typography, Paper, LinearProgress, Button } from '@material-ui/core'
import {Link } from 'react-router-dom'

const QuizGrid = ({ children, index, length, to }) => (
  <Grid container justify="center" spacing={16}>
    <Grid item xs={12} md={8}>
      {children}
    </Grid>
    <Grid item xs={12} md={4}>
      <Paper style={{ padding: 20 }}>
        <Typography variant="h5" style={{ marginBottom: 10 }}>{`${index + 1}/${
          length
        }`}</Typography>
        <LinearProgress
          variant="determinate"
          value={((index + 1) / length) * 100}
          style={{ marginBottom: 20 }}
        />
        <Button
          component={Link}
          to={to}
          variant="contained"
          color="primary"
          fullWidth
        >
          Done
        </Button>
      </Paper>
    </Grid>
  </Grid>
)

export default QuizGrid
