import { Component } from "react";
import { Link } from "react-router-dom";
import wr from "../../img/WR.png"
import "../notfound/notfound.css"

class NotFoundSalas extends Component
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
                <img className="img-nt" src={wr} alt="not found"/>
                <p className="p-nt">Para acesso a essa página você deverá ter efetuado um login</p>
                <Link to="/login" className="link-btn-nt">login</Link>
            </section>
        )
    }
}

export default NotFoundSalas;