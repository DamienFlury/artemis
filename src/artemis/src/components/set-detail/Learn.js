import React, { Component, Fragment } from 'react'
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
      items: props.set.words.map(word => ({ word: word, isCorrect: null })),
      showEnd: false
    }
  }

  handleChange = name => event => {
    this.setState({ [name]: event.target.value })
  }
  handleSubmit = event => {
    event.preventDefault()

    const newItems = this.state.items.slice()
    newItems[this.state.index].isCorrect =
      this.state.answer === newItems[this.state.index].word.backside

    this.setState(prevState => ({
      index: prevState.index + 1,
      items: newItems
    }))
  }

  render() {
    const { index, items } = this.state
    const { classes } = this.props
    const showEnd = index >= items.length

    return (
      <Grid container justify="center" spacing={16}>
        <Grid item xs={12} md={8}>
          <Card>
            <CardContent>
              {showEnd ? (
                <div>
                  <Typography variant="h4" gutterBottom>
                    Great work!
                  </Typography>
                  <Typography variant="h5">
                    Correct:{' '}
                    {Math.round(
                      (items.filter(item => item.isCorrect).length /
                        items.length) *
                        100 *
                        100
                    ) / 100}
                    %
                  </Typography>
                </div>
              ) : (
                <Fragment>
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
                      type="submit"
                      fullWidth
                    >
                      Okay
                    </Button>
                  </form>
                </Fragment>
              )}
            </CardContent>
          </Card>
        </Grid>
        <Grid item xs={12} md={4}>
          <Paper style={{ padding: 20 }}>
            <Typography variant="h5" style={{ marginBottom: 10 }}>
              {showEnd ? 'Done' : `${index + 1}/${this.state.items.length}`}
            </Typography>
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
                (this.state.items
                  .filter(item => item.isCorrect !== null)
                  .filter(item => !item.isCorrect).length /
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
