/*
02 - Escreva um programa orientado a objetos com as seguintes características:

Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade;
Uma classe Aluno derivada da classe Pessoa, com um método IrParaEscola;
Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto;
Na classe principal:
Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.
*/

using PessoaProfessorEAlunoOOP;

// Variaveis 
int typePerson = 0;
int teacherOf = 0;
int studentOf = 0;

// Pedindo infos 
Console.Write("Nome: ");
string namePeople = Console.ReadLine();

Console.Write("Idade: ");
int agePeople = Convert.ToInt32(Console.ReadLine());

Pessoa people = new Pessoa(namePeople, agePeople);

Console.WriteLine("---------------------------------------------");

people.Greet();
people.TellAge();

Console.WriteLine("---------------------------------------------");

// Verificando se é Professor ou Aluno
Console.WriteLine("1 - Sou Discente \n2 - Sou Aluno");
typePerson = Convert.ToInt32(Console.ReadLine());

while (typePerson < 1 || typePerson > 2)
{
    Console.WriteLine("Entrada inválida. Tente novamente \n1 - Sou Discente \n2 - Sou Aluno");
    typePerson = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("----------------------------------------------------------------------------------");
// Professor
if (typePerson == 1)
{
    Professor teacher = new Professor(namePeople, agePeople);
    Console.WriteLine("1 - Docente de Direito || 2 - Docente de Tecnologia");
    teacherOf = Convert.ToInt32(Console.ReadLine());

    // Verificando qual curso o professor Leciona
    while(teacherOf < 1 || teacherOf > 2)
    {
        Console.WriteLine("1 - Docente de Direito || 2 - Docente de Tecnologia");
        teacherOf = Convert.ToInt32(Console.ReadLine());
    }

    if(teacherOf == 1)
    {
        string explainLaw = teacher.ExplainLaw();
        Console.WriteLine(explainLaw);
    }
    else if(teacherOf == 2)
    {
        string explainTechnology = teacher.ExplainTechnology();
        Console.WriteLine(explainTechnology);
    }
    Console.WriteLine("----------------------------------------------------------------------------------");
}

// Aluno
else if(typePerson == 2)
{
    Aluno student = new Aluno(namePeople, agePeople);
    Console.WriteLine("1 - Sou aluno de Direito | 2 - Sou aluno de Tecnologia");
    studentOf = Convert.ToInt32(Console.ReadLine());

    // Verificando qual matéria o aluno cursa
    while (studentOf < 1 || studentOf > 2)
    {
        Console.WriteLine("1 - Sou aluno de Direito | 2 - Sou aluno de Tecnologia");
        studentOf = Convert.ToInt32(Console.ReadLine());
    }

    if (studentOf == 1)
    {
        Console.WriteLine("hmmm aulinha de Direito :) ");
        student.GoToSchool();
    }
    else if (studentOf == 2)
    {
        Console.WriteLine("hmmm aulinha de C# :) ");
        student.GoToSchool();
    }
    Console.WriteLine("----------------------------------------------------------------------------------");
}
