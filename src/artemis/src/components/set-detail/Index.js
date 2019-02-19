import React, { Fragment } from 'react'
import { Grid } from '@material-ui/core';
import LearnTypeCard from '../LearnTypeCard';
import WordTable from '../WordTable';

const Index = ({set}) => (
  <Fragment>
    <Grid container spacing={32}>
      <Grid item md={3} sm={6} xs={12}>
        <LearnTypeCard
          title="Cards"
          description="Learn your stuff with cards"
          to={`/sets/${set.id}/cards`}
        />
      </Grid>
      <Grid item md={3} sm={6} xs={12}>
        <LearnTypeCard
          title="Learn"
          description="Learn by typing"
          to={`/sets/${set.id}/learn`}
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
    <WordTable words={set.words} />
  </Fragment>
)

export default Index