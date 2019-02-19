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
import Cards from './components/study/Cards'
import Learn from './components/study/Learn'

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
              <Route exact path="/" component={Home} />
              <Route exact path="/sets" component={Sets} />
              <Route exact path="/sets/:id" component={SetDetail} />
              <Route exact path="/cards/:id" component={Cards} />
              <Route exact path="/learn/:id" component={Learn} />
            </Switch>
          </NavMenu>
        </BrowserRouter>
      </MuiThemeProvider>
    )
  }
}

export default App
