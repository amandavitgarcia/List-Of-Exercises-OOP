using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carros
{
    public class Carro
    {
        // Propriedades do carro
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Preco { get; set; }
        public bool Disponivel { get; set; }

        // Construtor
        public Carro(string modelo, int ano, double preco, bool disponivel)
        {
            Modelo = modelo;
            Ano = ano;
            Preco = preco;
            Disponivel = disponivel;
        }

        // Método 
        public void ExibeCarrosAbaixoDeCinquentaMil(List<Carro> carros)
        {
            //Verificação usando LINQ para encontrar veículos cujo valor seja menor do que 50mil
            var verificaValorCarros = carros.Where(carro => carro.Preco < 50000).ToList();

            foreach (var verificaValor in verificaValorCarros)
            {
                Console.WriteLine($"Veículo - Nome: {verificaValor.Modelo} \t Ano: {Ano} \t Preço do veículo: {verificaValor.Preco.ToString("C2")} \t Dísponivel pra compra: {verificaValor.Disponivel}");
                Console.WriteLine(new string('-', 120));
            }
            
        }


    }
}
