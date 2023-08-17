using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaProfessorEAlunoOOP
{
    public class Professor : Pessoa
    {
        public Professor(string name, int age) : base(name, age)
        {
            
        }

        // Método 
        public string ExplainLaw()
        {

           string lawMatter = " \n \n --- Bem vindos à aula de Direito Trabalhista --- \nA jornada de trabalho se refere às horas trabalhadas pelo empregado e, portanto, ao tempo que ele gasta em sua atividade profissional. A legislação trabalhista brasileira estabelece limites para a jornada de trabalho diária, semanal e mensal, a fim de garantir a saúde e o bem-estar dos trabalhadores.";

            return lawMatter;
        }

        public string ExplainTechnology()
        {
            string technologyMatter = " \n \n--- Bem vindos à aula de C# --- \nA orientação a objetos é um paradigma de programação que permite modelar e organizar um programa em termos de objetos, que são entidades que possuem atributos e comportamentos. Em C#, a orientação a objetos é uma das características mais importantes da linguagem.";

            return technologyMatter;
        }

    }
}
