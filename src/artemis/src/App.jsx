import React, { useState } from 'react';
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

const App = () => {
  const [themeType, setThemeType] = useState('dark');

  const toggleTheme = () => {
    setThemeType(themeType === 'dark' ? 'light' : 'dark');
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
  });

  return (
    <MuiThemeProvider theme={theme}>
      <CssBaseline />
      <BrowserRouter>
        <NavMenu onClick={toggleTheme}>
          <Switch>
            <Route path="/sets/:id" component={SetDetail} />
            <Route path="/sets" component={Sets} />
            <Route path="/create-set" component={CreateSet} />
            <Route path="/" component={Home} />
          </Switch>
        </NavMenu>
      </BrowserRouter>
    </MuiThemeProvider>
  );
};

export default App;
