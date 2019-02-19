import React, { Component } from 'react'
import Api from '../api'
import RouteComponent from '../RouteComponent'
import Loading from '../Loading'
import Cards from './set-detail/Cards'
import { Switch, Route } from 'react-router-dom'
import Index from './set-detail/Index'
import Learn from './set-detail/Learn'

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
        <Switch>
          <Route
            path="/sets/:id/cards"
            render={params => <Cards {...params} set={set} />}
          />
          <Route
            path="/sets/:id/learn"
            render={params => <Learn {...params} set={set} />}
          />
          <Route
            path="/sets/:id"
            render={params => <Index {...params} set={set} />}
          />
        </Switch>
      </RouteComponent>
    )
  }
}

export default SetDetail
