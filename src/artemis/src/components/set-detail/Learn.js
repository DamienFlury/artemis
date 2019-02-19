import React, { Component } from 'react'
import {
  Card,
  CardContent,
  Typography,
  TextField,
  Button,
  Grid,
  Paper,
  LinearProgress
} from '@material-ui/core'
import { Link } from 'react-router-dom'

export class Learn extends Component {
  state = {
    index: 0,
    answer: ''
  }

  handleChange = name => event => {
    this.setState({ [name]: event.target.value })
  }

  render() {
    const { index } = this.state
    const { set } = this.props
    return (
      <Grid container justify="center" spacing={16}>
        <Grid item xs={12} md={8}>
          <Card>
            <CardContent>
              <Typography variant="h4" gutterBottom>
                {set.words[index].frontside}
              </Typography>
              <form>
                <TextField
                  style={{ marginBottom: 20 }}
                  label="Answer"
                  value={this.state.answer}
                  onChange={this.handleChange('answer')}
                  fullWidth
                />
                <Button variant="contained" color="primary" fullWidth>
                  Okay
                </Button>
              </form>
            </CardContent>
          </Card>
        </Grid>
        <Grid item xs={12} md={4}>
          <Paper style={{ padding: 20 }}>
            <Typography
              variant="h5"
              style={{ marginBottom: 10 }}
            >{`${index + 1}/${set.words.length}`}</Typography>
            <LinearProgress
              variant="determinate"
              value={((index + 1) / set.words.length) * 100}
              style={{ marginBottom: 20 }}
            />
            <Button
              component={Link}
              to={`/sets/${set.id}`}
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
  }
}

export default Learn
