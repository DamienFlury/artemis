import React from 'react';
import { Typography } from '@material-ui/core';
import RouteComponent from '../RouteComponent';
import QuoteComponent from './QuoteComponent';

const Home = () => (
  <RouteComponent title="Hello, World!">
    <Typography variant="body1">
      Artemis is your place for learning foreign languages.
    </Typography>
    <QuoteComponent />
  </RouteComponent>
);

export default Home;
