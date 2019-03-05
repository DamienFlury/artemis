import Axios from 'axios';

const Api = Axios.create({
  baseURL: 'https://localhost:5001/api/',
});

export default Api;
