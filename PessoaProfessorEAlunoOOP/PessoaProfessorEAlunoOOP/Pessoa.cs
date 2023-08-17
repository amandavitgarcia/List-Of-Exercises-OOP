using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PessoaProfessorEAlunoOOP
{
    public class Pessoa
    {
        // Propriedades
        public string Name { get; set; }
        public int Age { get; set; }

        // Contrutores 
        public Pessoa(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // Métodos
        public  void Greet()
        {
            Console.WriteLine($"Olá, meu nome é {Name}.");
        }

        public void TellAge()
        {
            Console.WriteLine($"Eu tenho {Age} anos.");
        }

    }

}
