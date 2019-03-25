import React, { useContext, useState } from 'react';
import {
  Paper, TextField, Button, Typography,
} from '@material-ui/core';
import { withRouter } from 'react-router-dom';
import RouteComponent from '../RouteComponent';
import AuthContext from '../AuthContext';

const Login = ({ history }) => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [isError, setIsError] = useState(false);

  const { login } = useContext(AuthContext);

  const handleSubmit = (e) => {
    e.preventDefault();
    login(email, password).then(() => history.push('/')).catch(() => setIsError(true));
  };
  return (
    <RouteComponent title="Login">
      <Paper style={{ padding: 20 }}>
        <form onSubmit={handleSubmit}>
          <TextField label="Email" type="email" value={email} onChange={e => setEmail(e.target.value)} style={{ marginBottom: 20 }} fullWidth />
          <TextField label="Password" type="password" value={password} onChange={e => setPassword(e.target.value)} style={{ marginBottom: 20 }} fullWidth />
          <Button variant="contained" color="secondary" type="submit" fullWidth>Okay</Button>
        </form>
        {isError
        && (
        <div style={{
          backgroundColor: '#ff5454', borderRadius: 5, padding: 20, marginTop: 20,
        }}
        >
          <Typography style={{ color: 'black' }}>Incorrect username or password</Typography>
        </div>
        )}
      </Paper>
    </RouteComponent>
  );
};

export default withRouter(Login);
