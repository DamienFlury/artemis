import React, { useState, useEffect } from 'react';
import {
  MuiThemeProvider,
  CssBaseline,
  createMuiTheme,
} from '@material-ui/core';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import { blue } from '@material-ui/core/colors';
import Home from './components/Home';
import NavMenu from './shared/NavMenu';
import Sets from './components/Sets';
import SetDetail from './components/SetDetail';
import CreateSet from './components/CreateSet';
import AuthContext from './AuthContext';
import Login from './components/Login';
import Api from './Api';

const App = () => {
  const [themeType, setThemeType] = useState('dark');

  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const [token, setToken] = useState('');

  useEffect(() => {
    const themeTypeFromLocalStorage = localStorage.getItem('themeType');
    if (themeTypeFromLocalStorage) {
      setThemeType(themeTypeFromLocalStorage);
    }
  });

  const login = (email, password) => Api.post('auth', { email, password }).then((response) => {
    setIsLoggedIn(true);
    setToken(response.data.token);
  });

  const logout = () => {
    setIsLoggedIn(false);
    setToken('');
  };

  const toggleTheme = () => {
    const nextThemeType = themeType === 'dark' ? 'light' : 'dark';
    setThemeType(nextThemeType);
    localStorage.setItem('themeType', nextThemeType);
  };

  const theme = createMuiTheme({
    palette: {
      type: themeType,
      primary: blue,
    },
    typography: {
      useNextVariants: true,
      fontFamily: 'Raleway',
    },
    spacing: 8,
  });

  return (
    <MuiThemeProvider theme={theme}>
      <CssBaseline />
      <AuthContext.Provider value={{
        isLoggedIn, token, login, logout,
      }}
      >
        <BrowserRouter>
          <NavMenu onClick={toggleTheme}>
            <Switch>
              <Route path="/sets/:id" component={SetDetail} />
              <Route path="/sets" component={Sets} />
              <Route path="/create-set" component={CreateSet} />
              <Route path="/login" component={Login} />
              <Route path="/" component={Home} />
            </Switch>
          </NavMenu>
        </BrowserRouter>
      </AuthContext.Provider>
    </MuiThemeProvider>
  );
};

export default App;
