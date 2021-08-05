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
    public class SalaEquipController: ControllerBase   
    {
        private ISalaEquipRepository _SalaEquipRepository { get; set; }
        public SalaEquipController()
        {
            _SalaEquipRepository = new SalaEquipRepository();
        }
        [HttpPost]
        public IActionResult Post(SalaEquip NovoHistorico)
        {
            _SalaEquipRepository.Atualizar(NovoHistorico);
            _SalaEquipRepository.Cadastrar(NovoHistorico);
            return StatusCode(204);
        }
    }
}
