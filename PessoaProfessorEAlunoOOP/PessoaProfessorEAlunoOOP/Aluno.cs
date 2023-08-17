using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaProfessorEAlunoOOP
{
    public class Aluno : Pessoa     
    {   
        // Recebe as informações do nome e da idade através do construtor da classe base Pessoa, usando a palavra-chave base
        // É um construtor
        public Aluno(string StudentName, int StudentAge) : base(StudentName, StudentAge)
        {
            
        }

        //Métodos 
        public void GoToSchool()
        {
            Console.WriteLine($"Indo pra escola...");
        }
    }
}
