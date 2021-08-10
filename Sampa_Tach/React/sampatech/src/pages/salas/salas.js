import { Component } from "react";
import { Link } from "react-router-dom";
import { parseJWT } from "../../services/auth";
import "./salas.css";

class Salas extends Component
{
    constructor(props)
    {
        super(props);
        this.state={
            salasEquip : [],
            nomeUser : '',
        }
    }

    logout = () => {
        localStorage.removeItem('usuario-login');
    }

    nomeUser = () => {
        var nome = parseJWT().nome;

        this.setState({nomeUser : nome})

        console.log(nome)
    }

    componentDidMount = () => {
        this.listarSalasEquip()
        this.nomeUser()
    }

    listarSalasEquip = () => {
        fetch('http://localhost:5000/api/SalaEquip')

        .then(resp => resp.json())

        .then(resposta => this.setState({ salasEquip : resposta }))

        .catch((erro) => console.log(erro))
    }

    render()
    {
        return(
            <body className="body-sa">
    <div className="barralateral-sa"></div>

    <div className="organizar-sa">

        <header className="header-sa">
            <div className="header-meio0-sa">
                <Link to="/" className="a-sa">home</Link>
                <p className="a-sa">bem vindo {this.state.nomeUser}</p>
                <Link to="/login" className="a-sa" onClick={this.logout}>Logout</Link>
            </div>
            <div className="header-meio1-sa">
                <div className="area-bolinha-sa">
                </div>
                <div className="area-bolinha-sa">
                </div>
                <div className="area-bolinha-sa">
                </div>
            </div>
        </header>
        <main className="main-sa">

                
                <div class="meio-main-sa">
                        <table id="customers">
                            <tr class="tr-sa">
                                <th class="th-sa">Andar</th>
                                <th class="th-sa">Sala</th>
                                <th class="th-sa">Marca</th>
                                <th class="th-sa">Equipamento</th>
                            </tr>
                            {

                                this.state.salasEquip.map( (lista) => {
                                    return(

                            <tr class="tr-sa">
                                <td class="td-sa">{lista.idSalaNavigation.andar}º</td>
                                <td class="td-sa">{lista.idSalaNavigation.nome}</td>
                                <td class="td-sa">{lista.idEquipamentoNavigation.marca}</td>
                                <td class="td-sa">{lista.idEquipamentoNavigation.descricao}</td>
                            </tr>
                                    )
                                })

                            }
                           
                        </table>
                    </div>

        </main>
    </div> 
</body>
        )
    }
}

export default Salas;