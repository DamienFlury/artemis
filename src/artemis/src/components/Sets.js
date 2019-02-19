import React, { Component } from 'react'
import { List, ListItem, ListItemText } from '@material-ui/core'
import Api from '../api'
import { Link } from 'react-router-dom'
import RouteComponent from '../RouteComponent'
import Loading from '../Loading'

class Sets extends Component {
  state = {
    sets: [],
    isLoading: true
  }

  componentWillMount() {
    Api.get('wordsets').then(response => this.setState({ sets: response.data, isLoading: false }))
  }

  render = () =>
    this.state.isLoading ? (
      <Loading />
    ) : (
      <RouteComponent title="Sets">
        <List>
          {this.state.sets.map(set => (
            <ListItem
              button
              key={set.id}
              component={Link}
              to={`/sets/${set.id}`}
            >
              <ListItemText primary={set.title} />
            </ListItem>
          ))}
        </List>
      </RouteComponent>
    )
}

export default Sets
