import { Component } from "react";
import './cadastro.css'
import logo from '../../img/logo1.png'

class Cadastro extends Component
{
    constructor(props)
    {
        super(props);
        this.state={
            userName    : '',
            email       : '',
            senha       : '',
        }
    }

    atualizarState = (state) => {
        this.setState({ [state.target.name] : state.target.value})
    }

    cadastro = (event) =>{
        event.preventDefault()

        fetch('localhost',{
            method : 'POST',

            body : JSON.stringify({
                userName    : this.state.userName,
                email       : this.state.email,
                senha       : this.state.senha    
            }),
        })

        .then(resp => {

            if (resp.status === 201) {
                this.props.history.push('/')
            }
        })
    }

    render()
    {
        return(
            <main className="main-cd">
            <div className="barraLateral-cd"></div>
            <section className="section-cd">
                <div className="header-cd">
                    <p>cadastro</p>
                </div>
    
                <div className="login-cd">
    
                    <div className="meio0-cd">
                        <img src={logo} alt=""/>
                    </div>
    
                    <div className="meio1-cd">
                        <div className="linha-cd"></div>
                    </div>
    
                    <div className="meio2-cd">
    
                        <div className="forms-cd">
    
                            <form className="form-cd">
                                <div className="metadeForm-cd">
    
                                    <input className="input-cd" type="text" placeholder="Nome"/>
    
                                    <input className="input-cd" type="text" placeholder="email"/>
        
                                    <input className="input-cd" type="text" placeholder="senha"/>
                                </div>
    
                                <div className="btn-cd">
                                    
                                    <button className="button-cd" type="submit">cadastro</button>
    
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

export default Cadastro;