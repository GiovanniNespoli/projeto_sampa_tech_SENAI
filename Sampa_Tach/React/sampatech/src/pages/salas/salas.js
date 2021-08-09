import { Component } from "react";
import "./salas.css";

class Salas extends Component
{
    constructor(props)
    {
        super(props);
        this.state={
            salasEquip : [],
        }
    }

    componentDidMount = () => {
        this.listarSalasEquip()
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
                <a className="a-sa" href="./home.html">home</a>
                <a className="a-sa" href="#">salas</a>
                <a className="a-sa">[USER]</a>
            </div>
            <div className="header-meio1-sa">
                <div className="area-bolinha-sa">
                </div>
                <div className="area-bolinha-sa">
                    <div className="bolinha-sa"></div>
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