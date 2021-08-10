import axios from "axios";
import { Component } from "react";
import { parseJWT } from "../../services/auth";

import "./login.css";

import logo from "../../img/logo1.png";
import { Link } from "react-router-dom";

class Login extends Component
{
    constructor(props)
    {
        super(props);
        this.state={
            email           : '',
            senha           : '',
            errormensage    : '',
        }
    }

    efetuarlogin = (event) => {
        event.preventDefault()

        this.setState({errormensage : ''})

        axios.post('http://localhost:5000/api/Login',
        {
            email : this.state.email,
            senha : this.state.senha
        })
        
        .then(resp => {
            if (resp.status === 200) {
                
                localStorage.setItem('usuario-login', resp.data.token)
                
                console.log(resp.data.token)

                if (parseJWT().typeUser === 'False') {
                    this.props.history.push('/adm')
                }

                if (parseJWT().typeUser === 'True') {
                    this.props.history.push('/salas')
                }
            }
        })

        .catch( () => {
            this.setState({ errorMensage : "Email ou senha inválidos!! tente novamente"})
        })
        
    }

    atualizarState = (state) => 
    {
        this.setState({ [state.target.name] : state.target.value })

        // console.log(this.state.senha)
        // console.log(this.state.email)
    }

    render()
    {
        return(
        <main className="main-lg">
            <div className="barraLateral-lg"></div>
            <section className="section-lg">
                <div className="header-lg">
                    <p>login</p>
                </div>
    
                <div className="login-lg">
    
                    <div className="meio0-lg">
                        <img src={logo} alt=""/>
                    </div>
    
                    <div className="meio1-lg">
                        <div className="linha-lg"></div>
                    </div>
    
                    <div className="meio2-lg">
    
                        <div className="forms-lg">
    
                            <form className="form-lg" onSubmit={this.efetuarlogin}>
                                <div className="metadeForm-lg">
    
                                    <input className="input-lg" type="text" placeholder="email" name="email" value={this.state.email} onChange={this.atualizarState}/>
        
                                    <input className="input-lg" type="password" placeholder="senha" name="senha" value={this.state.senha} onChange={this.atualizarState}/>
                                </div>
    
                                <div className="btn-lg">
                                    
                                    <button type="submit">logar</button>
                    
                                    <p className="btn-p-lg">{this.state.errormensage}</p>
    
                                </div>
                            </form>

                            <div className="msm-cad-lg">
                                <p className="msm-p-lg">Não tem Login?</p>
                                <Link to="/cadastro" className="msm-p2-lg">Cadastre-se</Link>
                            </div>
    
                        </div>
    
                    </div>
    
                </div>
                
            </section>
        </main>
        )
    }
}

export default Login;