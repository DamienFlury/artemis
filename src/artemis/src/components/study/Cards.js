import React, { Component } from 'react'
import Api from '../../api'
import RouteComponent from '../../RouteComponent'
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
import Loading from '../../Loading'

export class Cards extends Component {
  state = {
    set: {},
    isLoading: true,
    index: 0,
    showFrontside: true
  }
  componentWillMount() {
    const { match } = this.props
    Api.get(`wordsets/${match.params.id}`).then(response =>
      this.setState({ set: response.data, isLoading: false })
    )
  }

  render() {
    const { set, isLoading, index } = this.state

    return isLoading ? (
      <Loading />
    ) : (
      <RouteComponent title={set.title}>
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
            <Paper style={{padding: 20}}>
              <Typography variant="headline" style={{marginBottom: 10}}>{`${index + 1}/${set.words.length}`}</Typography>
              <LinearProgress variant="determinate" value={(index + 1) / set.words.length * 100} />
            </Paper>
          </Grid>
        </Grid>
      </RouteComponent>
    )
  }
}

export default Cards
