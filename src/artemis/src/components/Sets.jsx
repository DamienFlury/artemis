import React, { useState, useEffect, useContext } from 'react';
import { List, ListItem, ListItemText } from '@material-ui/core';
import { Link } from 'react-router-dom';
import Api from '../Api';
import RouteComponent from '../RouteComponent';
import Loading from '../Loading';
import AuthContext from '../AuthContext';

const Sets = () => {
  const [sets, setSets] = useState([]);
  const [isLoading, setIsLoading] = useState(true);

  const { token } = useContext(AuthContext);

  useEffect(() => {
    Api.get('wordsets', {
      headers: {
        Authorization: `Bearer ${token}`,
      },
    }).then((response) => {
      setSets(response.data);
      setIsLoading(false);
    });
  }, []);

  return isLoading ? (
    <Loading />
  ) : (
    <RouteComponent title="Sets">
      <List>
        {sets.map(set => (
          <ListItem button key={set.id} component={Link} to={`/sets/${set.id}`}>
            <ListItemText primary={set.title} />
          </ListItem>
        ))}
      </List>
    </RouteComponent>
  );
};

export default Sets;
