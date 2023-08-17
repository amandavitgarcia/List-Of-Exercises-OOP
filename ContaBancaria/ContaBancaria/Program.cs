/*
03 - Crie uma classe ContaBancaria com os atributos numero, saldo, titular e limite. Crie uma lista de contas bancárias e preencha-a com algumas instâncias da classe ContaBancaria. Em seguida, crie um método que itera sobre a lista e imprime o número e o saldo de todas as contas cujo saldo é superior a 10.000 e cujo titular é uma pessoa física (ou seja, o nome do titular não contém "S/A" ou "LTDA").
*/
using ContaBancariaEx;

//Lista vazia que usará as props de ContaBancaria
var contasBancarias = new List<ContaBancaria>();

//Populando a lista
var titular1 = new ContaBancaria(953926333, 5000, "Amanda LTDA", 22, 100.000);
contasBancarias.Add(titular1);

var titular2 = new ContaBancaria(963021333, 44000, "Jhonatan", 22, 101.003);
contasBancarias.Add(titular2);

var titular3 = new ContaBancaria(993329333, 55000, "Ioná", 39, 102.000);
contasBancarias.Add(titular3);

var titular4 = new ContaBancaria(941704333, 66000, "Rodrigo", 38, 103.000);
contasBancarias.Add(titular4);

var titular5 = new ContaBancaria(984383333, 6000, "Sabrina", 16, 104.000);
contasBancarias.Add(titular5);

var titular6 = new ContaBancaria(333333333, 7000, "Julli S/A", 8, 105.000);
contasBancarias.Add(titular6);


Console.WriteLine(" --- Usuários do nosso Banco --- ");
foreach (var conta in contasBancarias)
{
    Console.WriteLine($"Nome Titular: {conta.TitularConta} \t Número da Conta: {conta.NumeroConta} \t Saldo: {conta.SaldoConta}");
}

Console.WriteLine(" \n\n--- Usuários com saldo superior a 10.000 e titular pessoa física --- ");
titular1.MostraUsuarios(contasBancarias);

Console.WriteLine(" \n\n--- Usuários com saldo superior a 10.000 e titular pessoa física --- \nUSANDO LINQ");
titular1.MostraUsuariosLinq(contasBancarias);