import './home.css';
import { Component } from 'react';

import logo from '../../img/logohome.png';
import fotohome from '../../img/home.png'
import { Link } from 'react-router-dom';

class Home extends Component{
  constructor(props)
  {
    super(props);
    this.state = {
      
    }
  }

  render()
  {
    return(
      <body className="body-hm">
    <div className="barralateral-hm"></div>

    <div className="organizar-hm">

        <header className="header-hm">
            <div className="header-meio0-hm">
                <Link to="/" className="a-hm">home</Link>
                <Link to="/salas" className="a-hm">salas</Link>
                <Link to="/login" className="a-hm">login</Link>
            </div>
            <div className="header-meio1-hm">
                <div className="area-bolinha-hm">
                    <div className="bolinha-hm"></div>
                </div>
                <div className="area-bolinha">
                </div>
                <div className="area-bolinha">
                </div>
            </div>
        </header>
        <main className="main-hm">
            <div className="meio1-hm">
                <div className="up-hm">
                    <img className="up-img-hm" src={logo} alt="logo"/>
                </div>
                <div className="down-hm">
                    <h1 className="h1-hm">O que é SampaTech?</h1>
                    <p className="p-hm">Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed et
                     massa lectus. Phasellus eu molestie felis. Suspendisse magna justo, 
                     imperdiet eu venenatis at, maximus nec urna. Nam cursus nulla eu 
                     tellus luctus congue. Vestibulum nisi quam, tempor in porta ac, 
                     fermentum condimentum diam. Nunc hendrerit aliquam ex, et porta 
                     tellus feugiat nec. Maecenas ultricies, neque sit amet rutrum 
                     tempus, sem felis laoreet magna, ac bibendum erat diam a ante.</p>
                </div>
            </div>
            <div className="meio2-hm">
                <img className="meio2-img-hm" src={fotohome} alt="imagem bonita de um pc"/>
            </div>
        </main>

    </div>

</body>
    )
  }
}

export default Home;