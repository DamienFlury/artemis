import React, { useState } from 'react';
import {
  Card,
  CardContent,
  Typography,
  TextField,
  Button,
  Grid,
  Paper,
  LinearProgress,
  withStyles,
} from '@material-ui/core';
import PropTypes from 'prop-types';
import { Link } from 'react-router-dom';

const Learn = ({ classes, set }) => {
  const [index, setIndex] = useState(0);
  const [answer, setAnswer] = useState('');
  const [isDisabled, setIsDisabled] = useState(false);
  const [items, setItems] = useState(
    set.words.map(word => ({ word, isCorrect: null })),
  );

  const handleSubmit = (event) => {
    event.preventDefault();
    let shouldBeDisabled = false;
    if (index >= set.words.length - 2) {
      shouldBeDisabled = true;
    }
    const newItems = items.slice();
    newItems[index].isCorrect = answer === newItems[index].word.backside;
    setIndex(index + 1);
    setIsDisabled(shouldBeDisabled);
    setItems(newItems);
  };

  return (
    <Grid container justify="center" spacing={16}>
      <Grid item xs={12} md={8}>
        <Card>
          <CardContent>
            <Typography variant="h4" gutterBottom>
              {items[index].word.frontside}
            </Typography>
            <form onSubmit={handleSubmit}>
              <TextField
                style={{ marginBottom: 20 }}
                label="Answer"
                value={answer}
                onChange={event => setAnswer(event.target.value)}
                fullWidth
              />
              <Button
                variant="contained"
                color="primary"
                disabled={isDisabled}
                type="submit"
                fullWidth
              >
                Okay
              </Button>
            </form>
          </CardContent>
        </Card>
      </Grid>
      <Grid item xs={12} md={4}>
        <Paper style={{ padding: 20 }}>
          <Typography variant="h5" style={{ marginBottom: 10 }}>
            {`${index
            + 1}/${items.length}`}

          </Typography>
          <LinearProgress
            variant="determinate"
            value={((index + 1) / items.length) * 100}
            style={{ marginBottom: 20 }}
          />
          <LinearProgress
            variant="determinate"
            value={
              (items.filter(item => item.isCorrect).length / items.length) * 100
            }
            style={{ marginBottom: 20 }}
            classes={{
              colorPrimary: classes.correct,
              barColorPrimary: classes.correctBar,
            }}
          />
          <LinearProgress
            variant="determinate"
            style={{ marginBottom: 20 }}
            value={
              (items
                .filter(item => item.isCorrect !== null)
                .filter(item => !item.isCorrect).length
                / items.length)
              * 100
            }
            classes={{
              colorPrimary: classes.incorrect,
              barColorPrimary: classes.incorrectBar,
            }}
          />
          <Button
            component={Link}
            to={`/sets/${1}`}
            variant="contained"
            color="primary"
            fullWidth
          >
            Done
          </Button>
        </Paper>
      </Grid>
    </Grid>
  );
};

const styles = () => ({
  correct: {
    backgroundColor: '#b0ff99',
  },
  correctBar: {
    backgroundColor: '#28b200',
  },
  incorrect: {
    backgroundColor: '#ff8c8c',
  },
  incorrectBar: {
    backgroundColor: '#ff0000',
  },
});

Learn.propTypes = {
  classes: PropTypes.objectOf(PropTypes.object).isRequired,
  set: PropTypes.objectOf(PropTypes.object).isRequired,
};

export default withStyles(styles)(Learn);
