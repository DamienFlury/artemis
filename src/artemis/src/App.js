import React, { Component } from 'react'
import {
  MuiThemeProvider,
  CssBaseline,
  createMuiTheme
} from '@material-ui/core'
import { BrowserRouter, Route, Switch } from 'react-router-dom'
import Home from './components/Home'
import NavMenu from './shared/NavMenu'
import Sets from './components/Sets'
import SetDetail from './components/SetDetail'
import { blue } from '@material-ui/core/colors'
import CreateSet from './components/CreateSet';

class App extends Component {
  state = {
    theme: 'dark'
  }

  toggleTheme = () => {
    this.setState(prevState => ({
      theme: prevState.theme === 'light' ? 'dark' : 'light'
    }))
  }

  render() {
    const theme = createMuiTheme({
      palette: {
        type: this.state.theme,
        primary: blue
      },
      typography: {
        useNextVariants: true,
        fontFamily: 'Raleway'
      }
    })
    return (
      <MuiThemeProvider theme={theme}>
        <CssBaseline />
        <BrowserRouter>
          <NavMenu onClick={this.toggleTheme}>
            <Switch>
              <Route path="/create-set" component={CreateSet} />
              <Route path="/sets/:id" component={SetDetail} />
              <Route path="/sets" component={Sets} />
              <Route path="/" component={Home} />
            </Switch>
          </NavMenu>
        </BrowserRouter>
      </MuiThemeProvider>
    )
  }
}

export default App
