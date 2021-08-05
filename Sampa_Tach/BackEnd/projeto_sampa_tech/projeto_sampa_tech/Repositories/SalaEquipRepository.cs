using Microsoft.EntityFrameworkCore;
using projeto_sampa_tech.Contexts;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Repositories
{
    public class SalaEquipRepository : ISalaEquipRepository
    {
        sampa_techContext ctx = new sampa_techContext();

        public void Atualizar( SalaEquip salaEquipAtualizada)
        {
            SalaEquip salaEquiBuscada = ctx.SalaEquips.FirstOrDefault(c=> c.IdEquipamento== salaEquipAtualizada.IdEquipamento && salaEquipAtualizada.DataSaida==null);
            

            if (salaEquipAtualizada.DataSaida >= DateTime.Today)
            {
                salaEquiBuscada.DataSaida = salaEquipAtualizada.DataSaida;
            }

            // Atualiza os dados buscados e as fk, a gente tem que atualiza a sala que está, tipo, peguei uma mesa na sala 1, sim, q qui a gente faz? KKKKKKKK, eu tenho eu acho
            ctx.SalaEquips.Update(salaEquiBuscada);

            // Salva as informações para serem gravadas no banco
            ctx.SaveChanges();


        }

        public SalaEquip BuscarPorId(int idSalaEquip)
        {
            return ctx.SalaEquips.Find(idSalaEquip);
        }

        public void Cadastrar(SalaEquip novaSalaEquip)
        {
            novaSalaEquip.DataEntrada = DateTime.Now;
            ctx.SalaEquips.Add(novaSalaEquip);

            ctx.SaveChanges();
        }

        public void Deletar(int idSalaEquip)
        {
            ctx.SalaEquips.Remove(BuscarPorId(idSalaEquip));

            ctx.SaveChanges();
        }

        public List<SalaEquip> ListarTodos()
        {
            return ctx.SalaEquips
                .Include(i => i.IdEquipamentoNavigation)
                .Include(i => i.IdSalaNavigation)
                .ToList();
        }
        //quer q eu peça ajuda pro paulo sobre esses quesitos? fala pra ele que tem 2 coisas pra resolver
        //o negocio da dashboard/relatorio, e o do cadastro de usuario pra ser apenas um tipo de usuario,
        //aff agr o bagulho ficou serio
    }
}
