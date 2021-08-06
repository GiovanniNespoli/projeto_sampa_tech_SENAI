using projeto_sampa_tech.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Interfaces
{
    interface ISalaRepository
    {
        List<Sala> Listar();

        Sala BuscarPorId(int idSala);

        void Cadastrar(Sala novaSala);

        void Atualizar(int idSala, Sala salaAtualizada);

        void Deletar(int idSala);
    }
}
