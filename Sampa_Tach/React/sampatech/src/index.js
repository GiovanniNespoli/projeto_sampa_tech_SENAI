import React from 'react';
import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom'

import './index.css';

import Home from './pages/home/home.js';
import NotFound from './pages/notfound/notfound';
import Login from './pages/login/login';
import Cadastro from './pages/cadastro/cadastro';
import Salas from './pages/salas/salas';
import ADM from './pages/adm/adm';

import reportWebVitals from './reportWebVitals';

const routing = (
  <Router>
    <div>
      <Switch>

        <Route exact path="/" component={Home} />
        <Route path="/notfound" component={NotFound} />
        <Route path="/login" component={Login} />
        <Route path="/cadastro" component={Cadastro} />
        <Route path="/salas" component={Salas} />
        <Route path="/adm" component={ADM} />

        <Redirect to="notfound"/>

      </Switch>
    </div>
  </Router>
)


ReactDOM.render(routing, document.getElementById('root')
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
