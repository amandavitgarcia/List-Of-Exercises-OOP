using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaContatos
{
    public class Agenda
    {
        // Propriedades
        public List<Compromisso> Compromissos { get; set; } // Recebe uma lista de Compromissos

        // Construtor
        public Agenda(List<Compromisso> compromissos)
        {
            Compromissos = compromissos;
        }

        // Método 
        public void ImprimeContatoDeCompromissosProximos()
        {        
            var compromissosFiltrado = Compromissos.Where(x => x.DataCompromisso.Month == DateTime.Now.Month);

            foreach (var compromisso in compromissosFiltrado)
            {
                var contatos = compromisso.Contatos;

                 
                foreach (var contato in contatos)
                {
                    Console.WriteLine($"{compromisso.DescricaoCompromisso} - {contato.Nome}");
                    
                }
                Console.WriteLine(new string('-', 120));
            }
        }
    }
}
