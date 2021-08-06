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
            Equipamento equipamentoBuscado = ctx.Equipamentos.Find(idEquipamento);
            
            if (equipamentoAtualizado.Marca != null)
            {
                equipamentoBuscado.Marca = equipamentoAtualizado.Marca;
            }

            if (equipamentoAtualizado.TipoEquipamento != null)
            {
                equipamentoBuscado.TipoEquipamento = equipamentoAtualizado.TipoEquipamento;
            }

            if (equipamentoAtualizado.NumeroSerie != null)
            {
                equipamentoBuscado.NumeroSerie = equipamentoAtualizado.NumeroSerie;
            }

            if (equipamentoAtualizado.Descricao != null)
            {
                equipamentoBuscado.Descricao = equipamentoAtualizado.Descricao;
            }

            if (equipamentoAtualizado.AtivoInativo != true || equipamentoAtualizado.AtivoInativo != false)
            {
                equipamentoBuscado.AtivoInativo = equipamentoAtualizado.AtivoInativo;
            }

            if (equipamentoAtualizado.NumeroPatrimonio != null)
            {
                equipamentoBuscado.NumeroPatrimonio = equipamentoAtualizado.NumeroPatrimonio;
            }
            ctx.Equipamentos.Update(equipamentoBuscado);
            ctx.SaveChanges();
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

        public List<Equipamento> Listar()
        {
            return ctx.Equipamentos.ToList();
        }
    }
}

