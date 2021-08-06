using projeto_sampa_tech.Contexts;
using projeto_sampa_tech.Domains;
using projeto_sampa_tech.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_sampa_tech.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        sampa_techContext ctx = new sampa_techContext();

        /// <summary>
        /// Busca um usuário existente
        /// </summary>
        /// <param name="email">O e-mail que o usuário digitou</param>
        /// <param name="senha">A senha que o usuário digitou</param>
        /// <returns>Um usuário encontrado</returns>
        public Usuario Login(string Email, string Senha)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.Email == Email && u.Senha == Senha);
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            //ai toda vez q algm for cadastra vai ser automaticamente true(1)
            novoUsuario.TipoUsuario = true;
            ctx.Usuarios.Add(novoUsuario);
           
            



            ctx.SaveChanges();
        }
    }
}
