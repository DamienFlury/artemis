import React from "react";
import PropTypes from "prop-types";
import { withStyles } from "@material-ui/core/styles";
import Table from "@material-ui/core/Table";
import TableBody from "@material-ui/core/TableBody";
import TableCell from "@material-ui/core/TableCell";
import TableHead from "@material-ui/core/TableHead";
import TableRow from "@material-ui/core/TableRow";
import Paper from "@material-ui/core/Paper";

const styles = theme => ({
  root: {
    width: "100%",
    marginTop: theme.spacing.unit * 3,
    overflowX: "auto"
  }
});

const WordTable = ({ classes, words }) => (
  <Paper className={classes.root}>
    <Table>
      <TableHead>
        <TableRow>
          <TableCell>Frontside</TableCell>
          <TableCell align="right">Backside</TableCell>
        </TableRow>
      </TableHead>
      <TableBody>
        {words.map(word => (
          <TableRow key={word.id}>
            <TableCell component="th" scope="row">
              {word.frontside}
            </TableCell>
            <TableCell align="right">{word.backside}</TableCell>
          </TableRow>
        ))}
      </TableBody>
    </Table>
  </Paper>
);

WordTable.propTypes = {
  classes: PropTypes.object.isRequired
};

export default withStyles(styles)(WordTable);
