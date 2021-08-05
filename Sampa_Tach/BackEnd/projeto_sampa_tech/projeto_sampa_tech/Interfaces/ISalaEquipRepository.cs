using projeto_sampa_tech.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Interfaces
{
    interface ISalaEquipRepository
    {
        List<SalaEquip> ListarTodos();

        SalaEquip BuscarPorId(int idSalaEquip);

        void Cadastrar(SalaEquip novaSalaEquip);

        void Atualizar( SalaEquip SalaEquipAtualizada);

        void Deletar(int idSalaEquip);
    }
}
