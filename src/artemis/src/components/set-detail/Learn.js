import React, { Component } from 'react'
import {
  Card,
  CardContent,
  Typography,
  TextField,
  Button,
  Grid,
  Paper,
  LinearProgress,
  withStyles
} from '@material-ui/core'
import { Link } from 'react-router-dom'

export class Learn extends Component {
  constructor(props) {
    super(props)
    this.state = {
      index: 0,
      answer: '',
      isDisabled: false,
      items: props.set.words.map(word => ({ word: word, isCorrect: null }))
    }
  }

  handleChange = name => event => {
    this.setState({ [name]: event.target.value })
  }
  handleSubmit = event => {
    event.preventDefault()
    let isDisabled = false
    if (this.state.index >= this.props.set.words.length - 2) {
      isDisabled = true
    }
    const newItems = this.state.items.slice()
    newItems[this.state.index].isCorrect = this.state.answer === newItems[this.state.index].word.backside
    this.setState(prevState => ({
      index: prevState.index + 1,
      isDisabled: isDisabled,
      items: newItems
    }))
  }

  render() {
    const { index, isDisabled } = this.state
    const { classes } = this.props
    return (
      <Grid container justify="center" spacing={16}>
        <Grid item xs={12} md={8}>
          <Card>
            <CardContent>
              <Typography variant="h4" gutterBottom>
                {this.state.items[index].word.frontside}
              </Typography>
              <form onSubmit={this.handleSubmit}>
                <TextField
                  style={{ marginBottom: 20 }}
                  label="Answer"
                  value={this.state.answer}
                  onChange={this.handleChange('answer')}
                  fullWidth
                />
                <Button
                  variant="contained"
                  color="primary"
                  disabled={isDisabled}
                  type="submit"
                  fullWidth
                >
                  Okay
                </Button>
              </form>
            </CardContent>
          </Card>
        </Grid>
        <Grid item xs={12} md={4}>
          <Paper style={{ padding: 20 }}>
            <Typography variant="h5" style={{ marginBottom: 10 }}>{`${index +
              1}/${this.state.items.length}`}</Typography>
            <LinearProgress
              variant="determinate"
              value={((index + 1) / this.state.items.length) * 100}
              style={{ marginBottom: 20 }}
            />
            <LinearProgress
              variant="determinate"
              value={
                (this.state.items.filter(item => item.isCorrect).length /
                  this.state.items.length) *
                100
              }
              style={{ marginBottom: 20 }}
              classes={{
                colorPrimary: classes.correct,
                barColorPrimary: classes.correctBar
              }}
            />
            <LinearProgress
              variant="determinate"
              style={{ marginBottom: 20 }}
              value={
                (this.state.items.filter(item => item.isCorrect !== null).filter(item => !item.isCorrect).length /
                  this.state.items.length) *
                100
              }
              classes={{
                colorPrimary: classes.incorrect,
                barColorPrimary: classes.incorrectBar
              }}
            />
            <Button
              component={Link}
              to={`/sets/${1}`}
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

const styles = theme => ({
  correct: {
    backgroundColor: '#b0ff99'
  },
  correctBar: {
    backgroundColor: '#28b200'
  },
  incorrect: {
    backgroundColor: '#ff8c8c'
  },
  incorrectBar: {
    backgroundColor: '#ff0000'
  }
})

export default withStyles(styles)(Learn)
