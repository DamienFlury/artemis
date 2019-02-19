import React, { Component } from 'react'
import {
  Card,
  CardContent,
  Typography,
  TextField,
  Button
} from '@material-ui/core'
import QuizGrid from './QuizGrid'

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
      <QuizGrid index={index} length={set.words.length} to={`/sets/${set.id}`}>
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
      </QuizGrid>
    )
  }
}

export default Learn
