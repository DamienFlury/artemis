import React, { Component } from 'react'
import {
  Grid,
  Card,
  CardContent,
  Typography,
  CardActionArea,
  Button,
} from '@material-ui/core'
import QuizGrid from './QuizGrid'

export class Cards extends Component {
  state = {
    index: 0,
    showFrontside: true
  }

  render() {
    const { index } = this.state
    const { set } = this.props

    return (
      <QuizGrid index={index} length={set.words.length} to={`/sets/${set.id}`}>
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
      </QuizGrid>
    )
  }
}

export default Cards
