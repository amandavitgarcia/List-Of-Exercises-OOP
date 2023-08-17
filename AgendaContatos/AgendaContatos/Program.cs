/*
05 - Crie uma classe Agenda com os atributos contatos e compromissos. O atributo contatos deve ser uma lista de objetos Contato, que devem ter os atributos nome e telefone. O atributo compromissos deve ser uma lista de objetos Compromisso, que devem ter os atributos data, horario e descricao. Crie uma lista de agendas e preencha-a com algumas instâncias da classe Agenda. Em seguida, crie um método que itera sobre a lista e imprime o nome de todos os contatos que possuem pelo menos um compromisso marcado para o mês atual (ou seja, o mês atual deve ser inferiror ou igual ao mês do compromisso). 
*/

using AgendaContatos;
using System.Globalization;

var listaAgendas = new List<Agenda>();
var listaCompromissos = new List<Compromisso>();
var listaContatos = new List<Contato>();


// Populando lista Contatos
var ctt1 = new Contato("João Silva", "(11) 9999-1234");
listaContatos.Add(ctt1);

var ctt2 = new Contato("Maria Santos", "(21) 9876-5432");
listaContatos.Add(ctt2);

var ctt3 = new Contato("Fernanda Lima", "(61) 5432-1098");
listaContatos.Add(ctt3);

var ctt4 = new Contato("Eduardo Oliveira", "(99) 1098-7654");
listaContatos.Add(ctt4);


// Populando lista Compromissos
var almocoEquipe = new Compromisso(DateTime.Now, "15:03", "Almoço Equipe", listaContatos);
listaCompromissos.Add(almocoEquipe);

var niverIa = new Compromisso(DateTime.Now.AddDays(5), "18:00", "Reunião Fornecedor", listaContatos);
listaCompromissos.Add(niverIa);

var niverMarcia = new Compromisso(DateTime.Now.AddDays(-50), "08:03", "Aniversário Marcia", listaContatos);
listaCompromissos.Add(niverMarcia);

var niverRafaela = new Compromisso(DateTime.Now.AddDays(3), "09:03", "Aniversário Rafaela", listaContatos);
listaCompromissos.Add(niverRafaela);

var dentista = new Compromisso(DateTime.Now.AddDays(20), "11:30", "Extração dente", listaContatos);
listaCompromissos.Add(dentista);

var agenda = new Agenda(listaCompromissos);

listaAgendas.Add(agenda);



Console.WriteLine("--- Lista Contatos ---");
foreach(var ctt in listaContatos)
{
    Console.WriteLine($"Nome: {ctt.Nome} | Telefone: {ctt.Telefone}");
    Console.WriteLine(new string('-', 120));
}

Console.WriteLine("\n--- Compromissos ---");
foreach(var compromissosMarcados in agenda.Compromissos)
{
    Console.WriteLine($"{compromissosMarcados.DescricaoCompromisso} - Dia {compromissosMarcados.DataCompromisso.ToString("dd/MM/yyyy")} às {compromissosMarcados.HorarioCompromisso}");
    Console.WriteLine(new string('-', 120));
}

Console.WriteLine($"\n \n--- Contatos que possuem compromisso para {DateTime.Now.ToString("MMMM", new CultureInfo("pt-BR"))} --- ");

foreach (var abAgenda in listaAgendas)
{
    agenda.ImprimeContatoDeCompromissosProximos();
}
