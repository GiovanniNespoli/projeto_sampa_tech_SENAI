using projeto_sampa_tech.Contexts;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Repositories
{
    public class EquipamentoRepository : IEquipamentosRepository
    {
        sampa_techContext ctx = new sampa_techContext();

        public void Atualizar(int idEquipamento, Equipamento equipamentoAtualizado)
        {
            throw new NotImplementedException();
        }

        public Equipamento BuscarPorId(int idEquipamento)
        {
            return ctx.Equipamentos.Find(idEquipamento);
        }

        public void Cadastrar(Equipamento novoEquipamento)
        {
            ctx.Equipamentos.Add(novoEquipamento);

            ctx.SaveChanges();
        }

        public void Deletar(int idEquipamento)
        {
            ctx.Equipamentos.Remove(BuscarPorId(idEquipamento));

            ctx.SaveChanges();
        }

        public List<Equipamento> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

