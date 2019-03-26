import React, { useState, useContext } from 'react';
import {
  TextField,
  Paper,
  Table,
  TableHead,
  TableRow,
  TableCell,
  TableBody,
  Typography,
  Grid,
  Button,
} from '@material-ui/core';
import RouteComponent from '../RouteComponent';
import AddWord from './AddWord';
import Api from '../Api';
import AuthContext from '../AuthContext';

const CreateSet = () => {
  const [words, setWords] = useState([]);
  const [title, setTitle] = useState('');

  const { token } = useContext(AuthContext);

  const handleClick = () => {
    Api.post('wordsets', {
      title,
      words,
    },
    {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    });
  };

  return (
    <RouteComponent title="Create Set">
      <Grid container spacing={32}>
        <Grid item xs={10}>
          <TextField label="Title" value={title} onChange={e => setTitle(e.target.value)} fullWidth />
        </Grid>
        <Grid item xs={2}>
          <Button color="primary" variant="contained" onClick={handleClick} fullWidth>Save</Button>
        </Grid>
      </Grid>
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
