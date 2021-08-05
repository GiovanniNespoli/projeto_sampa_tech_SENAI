﻿using Microsoft.EntityFrameworkCore;
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

        public void Atualizar(int id, SalaEquip salaEquipAtualizada)
        {
            SalaEquip salaEquiBuscada = ctx.SalaEquips.Find(id);
            
           
            if (salaEquipAtualizada.DataEntrada >= DateTime.Today)
            {
                salaEquiBuscada.DataEntrada = salaEquipAtualizada.DataEntrada;
            }

            if (salaEquipAtualizada.DataSaida >= DateTime.Today)
            {
                salaEquiBuscada.DataSaida = salaEquipAtualizada.DataSaida;
            }

            // Atualiza os dados buscados
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
    }
}