import { Component } from "react";
import { Link } from "react-router-dom";
import '../adm/adm.css'

class ADM extends Component
{
    constructor(props)
    {
        super(props);
        this.state={

            andar           : '',
            nome            : '',
            metragem        : '',

            marca           : '',
            tipo            : '',
            numSerie        : '',
            ativoIna        : 0,
            descric         : '',
            NumPatri        : '',

            listaSalaEquip  : [],
        }
    }

    alterarStates = (state) => {
        this.setState({ [state.target.name] : state.target.value })

        console.log(this.state.marca)
        console.log(this.state.tipo)
        console.log(this.state.numSerie)
        console.log(this.state.ativoIna)
        console.log(this.state.NumPatri)
    }

    limparStates = () => {
        this.setState({

            andar           : '',
            nome            : '',
            metragem        : '',
    
            marca           : '',
            tipo            : '',
            numSerie        : '',
            ativoIna        : 0,
            descric         : '',
            NumPatri        : '',
        })
    }

    logout = () => {
        localStorage.removeItem('usuario-login');
    }

    cadastrarEquip = (event) => {
        event.preventDefault();

        fetch('http://localhost:5000/api/Equipamento',
        {
            method : 'POST',

            body : JSON.stringify({
                marca           : this.state.marca,
                tipoEquipamento : this.state.tipo,
                numeroSerie     : this.state.numSerie,
                descricao       : this.state.descric,
                ativoInativo    : parseInt(this.state.ativoIna),
                numeroPatrimonio: this.state.NumPatri
            }),

            headers : {
                "Content-Type" : "application/json"
            }
        })

        .then(console.log("acho q deu bom lek rsrsrs"))
        .then(this.limparStates)
        .catch(erro => console.log(erro))
    }

    cadastrarSala = (event) => {
        event.preventDefault();

        fetch('http://localhost:5000/api/Sala',
        {
            method : 'POST',

            body : JSON.stringify({
                andar       : this.state.andar,
                nome        : this.state.nome,
                metragemSala: this.state.metragem,
            }),

            headers : {
                "Content-Type" : "application/json"
            }
        }
        )

        .then(console.log("deu bom lek"))
        .then(this.limparStates)
        .catch(erro => console.log(erro))
    }

    listaSalaEquip = () => {
        fetch('http://localhost:5000/api/SalaEquip')

        .then(resp => resp.json())

        .then(resposta => this.setState({ listaSalaEquip : resposta }))

        .catch((erro) => console.log(erro))

        console.log('ta funfando')
    }

    componentDidMount = () => {
        this.listaSalaEquip()
    }

    render()
    {
        return(
        <body className="body-adm">
            <div className="barralateral-adm"></div>
        
            <div className="organizar-adm">
        
                <header className="header-adm">
                    <div className="header-meio0-adm">
                        <Link to="/" className="a-adm">home</Link>
                        <a className="a-adm">acesso adm</a>
                        <Link to="/" onClick={this.logout} className="a-adm">Logout</Link>
                    </div>
                    <div className="header-meio1-adm">
                        <div className="area-bolinha-adm">
                        </div>
                        <div className="area-bolinha-adm">
                        </div>
                        <div className="area-bolinha-adm">
                        </div>
                    </div>
                </header> 
                <main className="main-adm">
                    <section className="cadastroSala-adm">
                        <form className="form-cadastroSala-adm" onSubmit={this.cadastrarSala}>
        
                            <div className="form-meio0-adm">
                                <p className="p-meio0-adm">nova sala</p>
                                <input className="input-adm" type="text" name="andar" value={this.state.andar} onChange={this.alterarStates} placeholder="Andar"/>
                                <input className="input-adm" type="text" name="nome" value={this.state.nome} onChange={this.alterarStates} placeholder="Nome"/>
                                <input className="input-adm" type="text" name="metragem" value={this.state.metragem} onChange={this.alterarStates} placeholder="Metragem"/>
                            </div>
                            <div className="form-meio1-adm">
                                <button type="submit" className="btn-adm">
                                    Cadastre uma sala
                                </button>
                            </div>
        
                        </form>
                    </section>
        
                    <section className="cadastroEquip-adm">
                        <form className="cadastroEquip-form-adm" onSubmit={this.cadastrarEquip}>
        
                            <div className="cadEquip-p">
                                <p className="cad-p-adm">novo equipamento</p>
                            </div>
        
                            <div className="cadEquip-input">
                                <div className="input1-adm">
                                    <input className="input-adm" value={this.state.marca} onChange={this.alterarStates} name="marca" type="text" placeholder="Marca"/>
                                    <input className="input-adm" value={this.state.tipo} onChange={this.alterarStates} name="tipo" type="text" placeholder="Tipo"/>
                                    <input className="input-adm" value={this.state.numSerie} onChange={this.alterarStates} name="numSerie" type="text" placeholder="Número de série"/>
                                </div>
                                <div className="input2-adm">
                                    <select className="input-adm" value={this.state.ativoIna} onChange={this.alterarStates} name="ativoIna">
                                        <option className="options-adm" value="0">Inativo</option>
                                        <option className="options-adm" value="1">Ativo</option>
                                    </select>
                                    <input className="input-adm" value={this.state.descric} onChange={this.alterarStates} name="descric" type="text" placeholder="Descrição"/>
                                    <input className="input-adm" value={this.state.NumPatri} onChange={this.alterarStates} name="NumPatri" type="text" placeholder="Patrimonio"/>
                                </div>
        
                                <div className="formBtn-adm">
                                    <button type="submit" className="formbtn-adm">Cadastre um novo equipamento</button>
                                </div>
                            </div>
                        </form>
                    </section>
        
                    <section className="tabela-adm">
                        <table id="customers">
                            <tr className="tr-adm">
                                <th>Marca</th>
                                <th>descrição</th>
                                <th>Nº de série</th>
                                <th>Nº de patrimonio</th>
                                <th>Data de entrada</th>
                                <th>Data de saída</th>
                              </tr>
                              {
                                this.state.listaSalaEquip.map( (lista) =>
                                {
                                    return(

                              <tr key={lista.idSalaEquip} className="tr-adm">
                                <td className="td-adm">{lista.idEquipamentoNavigation.marca}</td>
                                <td className="td-adm">{lista.idEquipamentoNavigation.descricao}</td>
                                <td className="td-adm">{lista.idEquipamentoNavigation.numeroSerie}</td>
                                <td className="td-adm">{lista.idEquipamentoNavigation.numeroPatrimonio}</td>
                                <td className="td-adm">{new Intl.DateTimeFormat('pt-BR').format(new Date(lista.dataEntrada))}</td>
                                <td className="td-adm">{new Intl.DateTimeFormat('pt-BR').format(new Date(lista.dataSaida))}</td>
                              </tr>
                                    )

                                })

                              }
                              
                        </table>
                    </section>
                </main>
            </div>
        </body> 
        )
    }
}

export default ADM;