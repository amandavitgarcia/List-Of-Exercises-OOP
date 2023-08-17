/*
05 - Crie uma classe Produto com os atributos nome, preco e quantidade. Crie uma lista de produtos e preencha-a com algumas instâncias da classe Produto. Em seguida, crie um método que itera sobre a lista e imprime o nome e o preço de todos os produtos que estão com desconto de 10%. Se a quantidade do produto for inferior a 10 unidades, dê um desconto adicional de 5%.
*/

using MiniMercadinho;

var produtosMercadinho = new List<Produto>();

var arroz = new Produto("Arroz", 23.00, 33);
produtosMercadinho.Add(arroz);

var feijao = new Produto("Feijão", 8.00, 15);
produtosMercadinho.Add(feijao);

var oleoDeSoja = new Produto("Oléo de Soja", 11.00, 10);
produtosMercadinho.Add(oleoDeSoja);

var acucar = new Produto("Açucar", 5.00, 100);
produtosMercadinho.Add(acucar);

var sal = new Produto("Sal", 4.50, 103);
produtosMercadinho.Add(sal);

var cafe = new Produto("Café", 21.30, 3);
produtosMercadinho.Add(cafe);

Console.WriteLine(" --- Produtos Mecadinho ---");

Console.WriteLine("10% de desconto na compra de mais de 10 unidades.");
arroz.MostraProdutosComDesconto(produtosMercadinho);