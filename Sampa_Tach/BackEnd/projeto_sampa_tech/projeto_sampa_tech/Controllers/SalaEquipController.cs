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
    public class SalaEquipController : ControllerBase
    {
        private ISalaEquipRepository _SalaEquipRepository { get; set; }
        public SalaEquipController()
        {
            _SalaEquipRepository = new SalaEquipRepository();
        }

        [HttpPost("novoHistorico/{id}")]
        public IActionResult Post(SalaEquip NovoHistorico, int id)
        {
            _SalaEquipRepository.Atualizar(NovoHistorico, id);
            _SalaEquipRepository.CadastrarI(NovoHistorico);
            return StatusCode(204);
        }

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
    }
}
