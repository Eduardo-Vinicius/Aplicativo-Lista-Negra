import axios from 'axios'

const api = axios.create({
    baseURL: 'https://nsf-lista-negra-eduardo.herokuapp.com/'
})

export default class ListaNegraApi {

    async cadastrar(ln) {
        const resp = await api.post('/listanegra', ln);
        console.log(resp);
        return resp;
    }

    async consultar() {
        const resp = await api.get('/listanegra');
        return resp.data;
    }

}