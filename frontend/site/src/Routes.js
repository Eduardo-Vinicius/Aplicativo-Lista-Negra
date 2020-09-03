import React from 'react'
import { BrowserRouter, Switch, Route } from 'react-router-dom';

import App from './Pages/App'
import Cadastrar from './Pages/Cadastrar'
import Consultar from './Pages/Consultar'



export default function Routes() {
    return (
        <BrowserRouter>
            <Switch>
                <Route path="/" exact={true} component={App} />
                <Route path="/cadastrar" component={Cadastrar} />
                <Route path="/consultar"  component={Consultar} />
               
            </Switch>
        </BrowserRouter>
    )
}