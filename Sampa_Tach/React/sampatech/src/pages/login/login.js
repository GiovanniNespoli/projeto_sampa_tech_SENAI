import axios from "axios";
import { Component } from "react";
import { parseJWT } from "../../services/auth";

import "./login.css";

import logo from "../../img/logo1.png";

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

        axios.post('localhost',
        {
            email : this.state.email,
            senha : this.state.senha
        })

        .then(resp => {
            if (resp.status === 200) {

                localStorage.setItem('usuario-login', resp.data.token)

                if (parseJWT().role === 1) {
                    this.props.history.push('/adm')
                }

                if (parseJWT().role === 2) {
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

        console.log(this.state.senha)
        console.log(this.state.email)
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
        
                                    <input className="input-lg" type="text" placeholder="senha" name="senha" value={this.state.senha} onChange={this.atualizarState}/>
                                </div>
    
                                <div className="btn-lg">
                                    
                                    <button type="submit">logar</button>

                                    <p className="btn-p-lg">{this.state.errormensage}</p>
    
                                </div>
                            </form>
    
                        </div>
    
                    </div>
    
                </div>
                
            </section>
        </main>
        )
    }
}

export default Login;