import React from 'react'
import { Button } from '@material-ui/core'
import RouteComponent from '../RouteComponent'

const Home = () => (
  <RouteComponent title="Hello, World!">
    <Button variant="contained" color="secondary" fullWidth>
      Click me!
    </Button>
  </RouteComponent>
)

export default Home
