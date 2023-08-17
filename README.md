# List-Of-Exercises-OOP
This project contains 5 exercises focused on Object-Oriented Programming (OOP) in C#. Each exercise represents a different concept, helping to understand the fundamental principles of OOP.

## Exercises

### 1. Exercise: PessoaProfessoreAluno
**Description:** Escreva um programa orientado a objetos com as seguintes características:
Uma classe Pessoa, com atributos nome e idade, e métodos Cumprimentar e DizerIdade;
Uma classe Aluno derivada da classe Pessoa, com um método IrParaEscola;
Uma classe Professor derivada da classe Pessoa, com um método Explicar que recebe como parâmetro um assunto;
Na classe principal:
Crie uma Pessoa e faça ela Cumprimentar e DizerIdade;
Crie um Aluno de 21 anos, e faça ele IrParaEscola, Cumprimentar e DizerIdade;
Crie um Professor de 30 anos, e faça ele Cumprimentar, DizerIdade e Explicar sobre um determinado assunto.
[View the code](https://github.com/amandavitgarcia/List-Of-Exercises-OOP/tree/main/PessoaProfessorEAlunoOOP)

### 2. Exercise: ContaBancaria
**Description:** Crie uma classe ContaBancaria com os atributos numero, saldo, titular e limite. Crie uma lista de contas bancárias e preencha-a com algumas instâncias da classe ContaBancaria. Em seguida, crie um método que itera sobre a lista e imprime o número e o saldo de todas as contas cujo saldo é superior a 10.000 e cujo titular é uma pessoa física (ou seja, o nome do titular não contém "S/A" ou "LTDA").
[View the code](https://github.com/amandavitgarcia/List-Of-Exercises-OOP/tree/main/ContaBancaria)

### 3. Exercise: Carros
**Description:** Crie uma classe Carro com os atributos modelo, ano, preco e disponivel. Crie uma lista de carros e preencha-a com algumas instâncias da classe Carro. Em seguida, crie um método que itera sobre a lista e imprime o modelo e o preço de todos os carros disponíveis cujo preço é inferior a 50.000.
[View the code](https://github.com/amandavitgarcia/List-Of-Exercises-OOP/tree/main/Carros)

### 4. Exercise: AgendaContatos
**Description:** Crie uma classe Agenda com os atributos contatos e compromissos. O atributo contatos deve ser uma lista de objetos Contato, que devem ter os atributos nome e telefone. O atributo compromissos deve ser uma lista de objetos Compromisso, que devem ter os atributos data, horario e descricao. Crie uma lista de agendas e preencha-a com algumas instâncias da classe Agenda. Em seguida, crie um método que itera sobre a lista e imprime o nome de todos os contatos que possuem pelo menos um compromisso marcado para o mês atual (ou seja, o mês atual deve ser inferiror ou igual ao mês do compromisso). 
[View the code](https://github.com/amandavitgarcia/List-Of-Exercises-OOP/tree/main/AgendaContatos)

### 5. Exercise: MiniMercadinho
**Description:** Crie uma classe Produto com os atributos nome, preco e quantidade. Crie uma lista de produtos e preencha-a com algumas instâncias da classe Produto. Em seguida, crie um método que itera sobre a lista e imprime o nome e o preço de todos os produtos que estão com desconto de 10%. Se a quantidade do produto for inferior a 10 unidades, dê um desconto adicional de 5%.
[View the code](https://github.com/amandavitgarcia/List-Of-Exercises-OOP/tree/main/MiniMercadinho)