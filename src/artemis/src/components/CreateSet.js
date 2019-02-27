import React, { Component } from 'react'
import RouteComponent from '../RouteComponent'
import {
  TextField,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Typography,
  Grid,
  Button
} from '@material-ui/core'

class CreateSet extends Component {
  state = {
    frontside: '',
    backside: '',
    words: []
  }

  render = () => (
    <RouteComponent title="Create Set">
      <TextField label="Title" fullWidth />
      <Paper style={{ marginTop: 40 }}>
        <AddWord
          onClick={(frontside, backside) =>
            !frontside || !backside
              ? null
              : this.setState({
                  words: [{ frontside: frontside, backside: backside }].concat(
                    this.state.words
                  )
                })
          }
        />
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>Frontside</TableCell>
              <TableCell>Backside</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {this.state.words.map((word, index) => (
              <TableRow key={index}>
                <TableCell>
                  <Typography>{word.frontside}</Typography>
                </TableCell>
                <TableCell>
                  <Typography>{word.backside}</Typography>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </Paper>
    </RouteComponent>
  )
}

export default CreateSet

class AddWord extends Component {
  handleChange = name => event => {
    this.setState({ [name]: event.target.value })
  }

  state = {
    frontside: '',
    backside: ''
  }

  handleSubmit = event => {
    event.preventDefault()
    this.props.onClick(this.state.frontside, this.state.backside)
    this.setState({ frontside: '', backside: '' })
  }

  render = () => (
    <form onSubmit={this.handleSubmit}>
      <Grid container spacing={32} style={{ padding: 20 }}>
        <Grid item sm={5} xs={12}>
          <TextField
            label="Frontside"
            value={this.state.frontside}
            onChange={this.handleChange('frontside')}
            fullWidth
          />
        </Grid>
        <Grid item sm={5} xs={12}>
          <TextField
            label="Backside"
            value={this.state.backside}
            onChange={this.handleChange('backside')}
            fullWidth
          />
        </Grid>
        <Grid item sm={2} xs={12}>
          <Button
            variant="contained"
            color="secondary"
            type="submit"
            fullWidth
          >
            Add
          </Button>
        </Grid>
      </Grid>
    </form>
  )
}
