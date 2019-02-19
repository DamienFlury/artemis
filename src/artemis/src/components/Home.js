import React from 'react'
import { Typography } from '@material-ui/core'
import RouteComponent from '../RouteComponent'

const Home = () => (
  <RouteComponent title="Hello, World!">
    <Typography variant="body1">Artemis is your place for learning foreign languages.</Typography>
  </RouteComponent>
)

export default Home
