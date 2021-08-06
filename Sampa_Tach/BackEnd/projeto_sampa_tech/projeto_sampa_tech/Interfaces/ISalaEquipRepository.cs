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

<<<<<<< HEAD
        void Atualizar(SalaEquip SalaEquipAtualizada);
=======
        void Atualizar( SalaEquip SalaEquipAtualizada);
>>>>>>> ac47a0d4c51b3e3f34b1bf942aa89ac3c8b73a0b

        void Deletar(int idSalaEquip);
    }
}
