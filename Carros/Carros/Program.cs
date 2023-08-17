/*
03 - Crie uma classe Carro com os atributos modelo, ano, preco e disponivel. Crie uma lista de carros e preencha-a com algumas instâncias da classe Carro. Em seguida, crie um método que itera sobre a lista e imprime o modelo e o preço de todos os carros disponíveis cujo preço é inferior a 50.000.
*/

using Carros;

// Lista que armazenará os carros baseando-se na classe Carro
var modeloCarros = new List<Carro>();

// Poplulando a lista
var porshe = new Carro("Porsche 911 Carrera 4S", 2020, 130000, false);
modeloCarros.Add(porshe);

var mercedez = new Carro("Mercedes-Benz C180 2015", 2015, 120000, true);
modeloCarros.Add(mercedez);

var corolla = new Carro("Toyota Corolla", 2005, 25000, false);
modeloCarros.Add(corolla);

var uno = new Carro("Fiat Uno Mille", 1995, 8000, false);
modeloCarros.Add(uno);

var opala = new Carro("Chevrolet Opala", 1976, 50000, true);
modeloCarros.Add(opala);

var renegade = new Carro("Jeep Renegade", 2014, 105000, true);
modeloCarros.Add(renegade);

// Mostrando todos os carros
Console.WriteLine(" --- Tabela de veículos ---\n");
foreach (var carro in modeloCarros)
{
    Console.WriteLine($"Veículo - Nome: {carro.Modelo} \t Ano: {carro.Ano} \t Preço do veículo: {carro.Preco.ToString("C2")} \t Dísponivel pra compra: {carro.Disponivel}");
    Console.WriteLine(new string('-', 120));
}

// Mostrando apenas os carros abaixo de 50mil baseando na validação feita no método ExibeCarrosAbaixoDeCinquentaMil
Console.WriteLine("\n \n--- Tabela de veículos abaixo de 50.000 --- \n");
porshe.ExibeCarrosAbaixoDeCinquentaMil(modeloCarros);