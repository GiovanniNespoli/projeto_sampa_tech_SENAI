import { Component } from "react";
import { Link } from "react-router-dom";
import nt from "../../img/NT.png"
import "../notfound/notfound.css"

class NotFound extends Component
{
    constructor(props)
    {
        super(props);
        this.state = {

        }
    }

    render()
    {
        return(
            <section className="sec-nt">
                <img className="img-nt" src={nt} alt="not found"/>
                <p className="p-nt">not found!!</p>
                <Link to="/" className="link-nt">clique aqui para voltar</Link>
            </section>
        )
    }
}

export default NotFound;