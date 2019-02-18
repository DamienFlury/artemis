import React, { Component } from 'react'
import Api from '../../api'
import RouteComponent from '../../RouteComponent'
import {
  Grid,
  Card,
  CardContent,
  Typography,
  CardActionArea,
  Button
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
    const { set, isLoading } = this.state

    return isLoading ? (
      <Loading />
    ) : (
      <RouteComponent title={set.title}>
        <Grid container justify="center">
          <Grid item style={{ width: '80%' }}>
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
            <Grid container justify="space-between" style={{marginTop: 20}}>
              <Button
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
        </Grid>
      </RouteComponent>
    )
  }
}

export default Cards
