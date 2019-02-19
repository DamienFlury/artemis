import React, { Component } from 'react'
import {
  Grid,
  Card,
  CardContent,
  Typography,
  CardActionArea,
  Button,
  Paper,
  LinearProgress
} from '@material-ui/core'
import { Link } from 'react-router-dom'

export class Cards extends Component {
  state = {
    index: 0,
    showFrontside: true
  }

  render() {
    const { index } = this.state
    const { set } = this.props

    return (
      <Grid container justify="center" spacing={16}>
        <Grid item xs={12} md={8}>
          <Card>
            <CardActionArea
              onClick={() =>
                this.setState(prevState => ({
                  showFrontside: !prevState.showFrontside
                }))
              }
              style={{ padding: 50 }}
            >
              <CardContent>
                <Typography variant="h3">
                  {this.state.showFrontside
                    ? set.words[this.state.index].frontside
                    : set.words[this.state.index].backside}
                </Typography>
              </CardContent>
            </CardActionArea>
          </Card>
          <Grid container justify="space-between" style={{ marginTop: 20 }}>
            <Button
              disabled={index <= 0}
              onClick={() =>
                this.setState(prevState => ({
                  index: prevState.index - 1,
                  showFrontside: true
                }))
              }
            >
              Back
            </Button>
            <Button
              disabled={index >= set.words.length - 1}
              onClick={() =>
                this.setState(prevState => ({
                  index: prevState.index + 1,
                  showFrontside: true
                }))
              }
            >
              Next
            </Button>
          </Grid>
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

export default Cards
