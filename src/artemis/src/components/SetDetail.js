import React, { Component } from 'react'
import { Grid } from '@material-ui/core'
import Api from '../api'
import LearnTypeCard from './LearnTypeCard'
import WordTable from './WordTable'
import RouteComponent from '../RouteComponent'
import Loading from '../Loading'

class SetDetail extends Component {
  state = {
    set: {},
    isLoading: true
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
        <Grid container spacing={32}>
          <Grid item md={3} sm={6} xs={12}>
            <LearnTypeCard
              title="Cards"
              description="Learn your stuff with cards"
              to={`/cards/${set.id}`}
            />
          </Grid>
          <Grid item md={3} sm={6} xs={12}>
            <LearnTypeCard
              title="Learn"
              description="Learn by typing"
              to={`/learn/${set.id}`}
            />
          </Grid>
          <Grid item md={3} sm={6} xs={12}>
            <LearnTypeCard
              title="Test"
              description="Test your knowledge"
              to={`/test/${set.id}`}
            />
          </Grid>
          <Grid item md={3} sm={6} xs={12}>
            <LearnTypeCard
              title="Something Else"
              description="Something else"
              to={`/something/${set.id}`}
            />
          </Grid>
        </Grid>
        <WordTable words={this.state.set.words} />
      </RouteComponent>
    )
  }
}

export default SetDetail
