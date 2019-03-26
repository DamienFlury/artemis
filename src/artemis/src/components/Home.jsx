import React from 'react';
import { Typography } from '@material-ui/core';
import RouteComponent from '../RouteComponent';
import Quote from './Quote';

const Home = () => (
  <RouteComponent title="Hello, World!">
    <Typography variant="body1">
      Artemis is your place for learning foreign languages.
    </Typography>
    <Quote />
  </RouteComponent>
);

export default Home;
