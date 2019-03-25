import React, { Fragment } from 'react';
import { Divider, Typography } from '@material-ui/core';
import PropTypes from 'prop-types';

const RouteComponent = ({ title, children }) => (
  <Fragment>
    <Typography variant="h2" style={{ paddingBottom: 20 }}>
      {title}
    </Typography>
    <Divider style={{ marginBottom: 20 }} />
    {children}
  </Fragment>
);

RouteComponent.propTypes = {
  title: PropTypes.string.isRequired,
  children: PropTypes.oneOfType(
    [PropTypes.element, PropTypes.arrayOf(PropTypes.element)],
  ).isRequired,
};

export default RouteComponent;
