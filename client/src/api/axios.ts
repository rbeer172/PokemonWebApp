import axios from 'axios';

const instance = axios.create();

instance.interceptors.request.use((config) => ({
    ...config,
    baseURL: 'https://localhost:44306',
}));
instance.interceptors.response.use((response) => {
    if (response.status >= 200) {
        return Promise.resolve(response.data);
    }
    return Promise.reject(response);
});

export default instance;
