using projeto_sampa_tech.Contexts;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Repositories
{
    public class SalaRepository : ISalaRepository
    {
        sampa_techContext ctx = new sampa_techContext();

        public void Atualizar(int idSala, Sala salaAtualizada)
        {
            Sala salaBuscada = ctx.Salas.Find(idSala);

            if (salaAtualizada.Andar != null)
            {
                salaBuscada.Andar = salaAtualizada.Andar;
            }

            if (salaAtualizada.Nome != null)
            {
                salaBuscada.Nome = salaAtualizada.Nome;
            }

            if (salaAtualizada.MetragemSala != null)
            {
                salaBuscada.MetragemSala = salaAtualizada.MetragemSala;
            }
            ctx.Salas.Update(salaBuscada);
            ctx.SaveChanges();
        }

        public Sala BuscarPorId(int idSala)
        {
            return ctx.Salas.Find(idSala);
        }

        public void Cadastrar(Sala novaSala)
        {
            ctx.Salas.Add(novaSala);

            ctx.SaveChanges();
        }

        public void Deletar(int idSala)
        {
            ctx.Salas.Remove(BuscarPorId(idSala));

            ctx.SaveChanges();
        }

        public List<Sala> Listar()
        {
            return ctx.Salas.ToList();
        }
    }
}
