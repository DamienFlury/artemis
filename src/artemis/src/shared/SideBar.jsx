import React, { useContext } from 'react';
import { Link } from 'react-router-dom';
import {
  List, ListItem, ListItemIcon, ListItemText,
} from '@material-ui/core';
import LibraryAddIcon from '@material-ui/icons/LibraryAdd';
import HomeIcon from '@material-ui/icons/Home';
import AssessmentIcon from '@material-ui/icons/Assessment';
import ExitToAppIcon from '@material-ui/icons/ExitToApp';
import PowerSettingsNewIcon from '@material-ui/icons/PowerSettingsNew';

import AuthContext from '../AuthContext';

const LoggedOutItems = () => (
  <ListItem button component={Link} to="/login">
    <ListItemIcon>
      <ExitToAppIcon />
    </ListItemIcon>
    <ListItemText primary="Login" />
  </ListItem>
);

const LoggedInItems = () => {
  const { logout } = useContext(AuthContext);
  return (
    <>
      <ListItem button component={Link} to="/sets">
        <ListItemIcon>
          <AssessmentIcon />
        </ListItemIcon>
        <ListItemText primary="My Sets" />
      </ListItem>
      <ListItem button component={Link} to="/create-set">
        <ListItemIcon>
          <LibraryAddIcon />
        </ListItemIcon>
        <ListItemText primary="Create Set" />
      </ListItem>
      <ListItem button onClick={logout}>
        <ListItemIcon>
          <PowerSettingsNewIcon />
        </ListItemIcon>
        <ListItemText primary="Logout" />
      </ListItem>
    </>
  );
};

const SideBar = () => {
  const { isLoggedIn } = useContext(AuthContext);
  return (
    <>
      <List>
        <ListItem button component={Link} to="/">
          <ListItemIcon>
            <HomeIcon />
          </ListItemIcon>
          <ListItemText primary="Home" />
        </ListItem>
        {isLoggedIn ? <LoggedInItems /> : <LoggedOutItems />}
      </List>
    </>
  );
};


export default SideBar;
