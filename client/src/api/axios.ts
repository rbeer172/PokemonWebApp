import axios from 'axios';

const instance = axios.create();

instance.interceptors.request.use((config) => ({
    ...config,
}));

export default instance;
