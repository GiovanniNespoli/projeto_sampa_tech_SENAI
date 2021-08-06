<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using projeto_sampa_tech.Repositories;
using System;
=======
﻿using System;
>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Controllers
{
<<<<<<< HEAD
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]


    public class CadastroUController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public CadastroUController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Post(Usuario cadastro)
        {
            try
            {
                // Faz a chamada para o método
                _usuarioRepository.Cadastrar(cadastro);

                // Retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
=======
    public class CadastroUController
    {

>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b
    }
}
