import React, { useState } from 'react';
import {
  TextField,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Typography,
} from '@material-ui/core';
import RouteComponent from '../RouteComponent';
import AddWord from './AddWord';

const CreateSet = () => {
  const [words, setWords] = useState([]);

  return (
    <RouteComponent title="Create Set">
      <TextField label="Title" fullWidth />
      <Paper style={{ marginTop: 40 }}>
        <AddWord
          onClick={(fSide, bSide) => (!fSide || !bSide
            ? null
            : setWords([{ frontside: fSide, backside: bSide }].concat(words)))
          }
        />
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>Frontside</TableCell>
              <TableCell>Backside</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {words.map((word, index) => (
              // eslint-disable-next-line react/no-array-index-key
              <TableRow key={index}>
                <TableCell>
                  <Typography>{word.frontside}</Typography>
                </TableCell>
                <TableCell>
                  <Typography>{word.backside}</Typography>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </Paper>
    </RouteComponent>
  );
};

export default CreateSet;
