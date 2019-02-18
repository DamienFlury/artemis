import React, { Fragment } from 'react'
import { Divider, Typography } from '@material-ui/core'

const RouteComponent = ({ title, children }) => (
  <Fragment>
    <Typography variant="h2" style={{ paddingBottom: 20 }}>
      {title}
    </Typography>
    <Divider style={{ marginBottom: 20 }} />
    {children}
  </Fragment>
)

export default RouteComponent
