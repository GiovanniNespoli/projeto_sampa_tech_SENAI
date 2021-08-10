using System;
using System.Collections.Generic;

#nullable disable

namespace projeto_sampa_tech.Domains
{
    public partial class Sala
    {
        public Sala()
        {
            SalaEquips = new HashSet<SalaEquip>();
        }

        public int IdSala { get; set; }
        public string Andar { get; set; }
        public string Nome { get; set; }
        public string MetragemSala { get; set; }

        public virtual ICollection<SalaEquip> SalaEquips { get; set; }
    }
}
