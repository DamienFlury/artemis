import React from 'react';
import {
  Card,
  CardActionArea,
  CardMedia,
  CardContent,
  Typography,
  withStyles,
} from '@material-ui/core';
import { Link } from 'react-router-dom';
import PropTypes from 'prop-types';

const LearnTypeCard = ({
  classes, title, description, to,
}) => (
  <Card className={classes.card} style={{ height: '100%' }}>
    <CardActionArea component={Link} to={to}>
      <CardMedia
        className={classes.media}
        image="https://image.stern.de/7528150/16x9-940-529/9326ee6ab163d3db91dd3ba9701a54d6/EP/harold-hide-the-pain-meme-09.jpg"
        title="lol"
      />
      <CardContent>
        <Typography gutterBottom variant="h5">
          {title}
        </Typography>
        <Typography>{description}</Typography>
      </CardContent>
    </CardActionArea>
  </Card>
);

const styles = {
  card: {
    display: 'block',
  },
  media: {
    height: 140,
  },
};

LearnTypeCard.propTypes = {
  classes: PropTypes.objectOf(PropTypes.object).isRequired,
  title: PropTypes.string.isRequired,
  description: PropTypes.string.isRequired,
  to: PropTypes.string.isRequired,
};

export default withStyles(styles)(LearnTypeCard);
