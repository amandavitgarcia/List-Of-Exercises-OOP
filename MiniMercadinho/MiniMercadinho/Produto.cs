using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniMercadinho
{
    public class Produto
    {
        public string NomeProduto { get; set; }
        public double PrecoProduto { get; set; }
        public int QtdProduto { get; set; }

        public Produto(string nomeProduto, double precoProduto, int qtdProduto)
        {
            NomeProduto = nomeProduto;
            PrecoProduto = precoProduto;
            QtdProduto = qtdProduto;
        }

        public void MostraProdutosComDesconto(List<Produto>produtosMercadinho)
        {
            foreach (var produto in produtosMercadinho)
            {
                double desconto;
                // Checando a quantidade de produto pra aplicar os descontos 
                if (produto.QtdProduto < 10) //Se for menor que 10 unidades aplica 5% de desconto
                {
                    desconto = 0.05;
                }
                else // se não aplica 10%
                {
                    desconto = 0.1;
                }

                // atribuindo a variavel precoComDesconto o valor do produto com os descontos aplicados. 
                double precoProdutoComDesconto = produto.PrecoProduto - (produto.PrecoProduto * desconto);

                Console.WriteLine($"{produto.NomeProduto} - Preço original: R${produto.PrecoProduto:F2} | {produto.QtdProduto} unidades | Preço com desconto: R${precoProdutoComDesconto:F2}");
                Console.WriteLine(new string('-', 120)); 
            }
        }
    }
}
