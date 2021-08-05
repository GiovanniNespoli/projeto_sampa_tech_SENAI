using projeto_sampa_tech.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Interfaces
{
    interface IUsuarioRepository
    {
        /// <summary>
        /// Busca um usuário existente
        /// </summary>
        /// <param name="Email">O e-mail que o usuário digitou</param>
        /// <param name="Senha">A senha que o usuário digitou</param>
        /// <returns>Um usuário encontrado</returns>

        Usuario Login(string Email, string Senha);
    }
}
