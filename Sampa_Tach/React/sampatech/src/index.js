import ReactDOM from 'react-dom';
import { Route, BrowserRouter as Router, Switch, Redirect } from 'react-router-dom'

import './index.css';

import Home from './pages/home/home.js';
import NotFound from './pages/notfound/notfound';
import NotSalas from './pages/notfound/notfoundSALAS'
import Login from './pages/login/login';
import Cadastro from './pages/cadastro/cadastro';
import Salas from './pages/salas/salas';
import ADM from './pages/adm/adm';

import { userLogado, parseJWT } from './services/auth';

import reportWebVitals from './reportWebVitals';

const PermissaoAdm = ({ component : Component }) =>
(
  <Route 
    render = {props =>
    
      userLogado() && parseJWT().typeUser === 'False' ?

      <Component {...props}/> :

      <Redirect to="/notfound"/>
    }
  >

  </Route>
)

const PermissaoUser = ({ component : Component }) =>
(
  <Route 
    render = {props => 
    
      userLogado() && parseJWT().typeUser === 'True' ?

      <Component {...props}/> :

      <Redirect to="/notSalas"/>

    }
  >

  </Route>
)

const routing = (
  <Router>
    <div>
      <Switch>

        <Route exact path="/" component={Home} />
        <Route path="/notfound" component={NotFound} />
        <Route path="/login" component={Login} />
        <Route path="/cadastro" component={Cadastro} />
        <Route path="/notSalas" component={NotSalas} />
        <PermissaoUser path="/salas" component={Salas} />
        <PermissaoAdm path="/adm" component={ADM} />

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
