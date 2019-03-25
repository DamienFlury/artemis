import React from 'react';
import { Typography, Button } from '@material-ui/core';
import { Link } from 'react-router-dom';
import RouteComponent from '../RouteComponent';
import QuoteComponent from './QuoteComponent';

const Home = () => (
  <RouteComponent title="Hello, World!">
    <Typography variant="body1">
      Artemis is your place for learning foreign languages.
    </Typography>
    <QuoteComponent />
    <Button
      variant="contained"
      color="primary"
      style={{ marginTop: 20 }}
      size="large"
      component={Link}
      to="/sets"
    >
      My Sets
    </Button>
    <Button
      variant="contained"
      color="primary"
      style={{ marginTop: 20 }}
      size="large"
      component={Link}
      to="/create-set"
    >
      Create Set
    </Button>
  </RouteComponent>
);

export default Home;
