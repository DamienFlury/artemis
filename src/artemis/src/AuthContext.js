import React from 'react';

const AuthContext = React.createContext({
  isLoggedIn: false,
  token: '',
  login: () => {},
  logout: () => {},
});

export default AuthContext;
