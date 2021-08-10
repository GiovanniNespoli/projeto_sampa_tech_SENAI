using System;
using System.Collections.Generic;

#nullable disable

namespace projeto_sampa_tech.Domains
{
    public partial class Equipamento
    {
        public Equipamento()
        {
            SalaEquips = new HashSet<SalaEquip>();
        }

        public int IdEquipamento { get; set; }
        public string Marca { get; set; }
        public string TipoEquipamento { get; set; }
        public string NumeroSerie { get; set; }
        public string Descricao { get; set; }
        public bool AtivoInativo { get; set; }
        public string NumeroPatrimonio { get; set; }

        public virtual ICollection<SalaEquip> SalaEquips { get; set; }
    }
}
