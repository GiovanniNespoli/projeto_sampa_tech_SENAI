using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using projeto_sampa_tech.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Controllers
{
    [Produces("application/json")]
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
<<<<<<< HEAD
    public class SalaEquipController : ControllerBase
=======
    public class SalaEquipController: ControllerBase   
>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b
    {
        private ISalaEquipRepository _SalaEquipRepository { get; set; }
        public SalaEquipController()
        {
            _SalaEquipRepository = new SalaEquipRepository();
        }
<<<<<<< HEAD

        [HttpPost("novoHistorico")]
=======
        [HttpPost]
>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b
        public IActionResult Post(SalaEquip NovoHistorico)
        {
            _SalaEquipRepository.Atualizar(NovoHistorico);
            _SalaEquipRepository.Cadastrar(NovoHistorico);
            return StatusCode(204);
        }
<<<<<<< HEAD

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                
                // Faz a chamada para o método
                _SalaEquipRepository.Deletar(id);

                // Retorna um status code
                return StatusCode(204);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Posta(SalaEquip novaSalaEquip)
        {
            try
            {
                // Faz a chamada para o método
                _SalaEquipRepository.Cadastrar(novaSalaEquip);

                // Retorna um status code
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                // Retorna a resposta da requisição fazendo a chamada para o método
                return Ok(_SalaEquipRepository.ListarTodos());
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
=======
>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b
    }
}
