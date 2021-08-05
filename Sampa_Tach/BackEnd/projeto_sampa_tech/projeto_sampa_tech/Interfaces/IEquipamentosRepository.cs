using projeto_sampa_tech.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Interfaces
{
    interface IEquipamentosRepository
    {
        List<Equipamento> ListarTodos();

        Equipamento BuscarPorId(int idEquipamento);

        void Cadastrar(Equipamento novoEquipamento);

        void Atualizar(int idEquipamento, Equipamento equipamentoAtualizado);

        void Deletar(int idEquipamento);
    }
}
