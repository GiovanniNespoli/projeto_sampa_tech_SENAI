using System;
using System.Collections.Generic;

#nullable disable

namespace projeto_sampa_tech.Domains
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool TipoUsuario { get; set; }
    }
}
