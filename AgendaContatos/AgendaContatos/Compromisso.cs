using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos
{
    public class Compromisso
    {
        public DateTime DataCompromisso { get; set; }
        public string HorarioCompromisso { get; set; }
        public string DescricaoCompromisso { get; set; }
        public List<Contato> Contatos { get; set; } // Recebe uma lista de Contatos

        public Compromisso(DateTime dataCompromisso, string horarioCompromisso, string descricaoCompromisso, List<Contato> listaContato)
        {
            DataCompromisso = dataCompromisso;
            HorarioCompromisso = horarioCompromisso;
            DescricaoCompromisso = descricaoCompromisso;
            Contatos = listaContato;
        }
    }
}
