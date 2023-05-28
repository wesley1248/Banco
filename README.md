# Banco

Este é um projeto de exemplo de um sistema bancário simples implementado em C#. Ele permite que o usuário realize operações como adicionar saldo e fazer saques em uma conta bancária.

## Classe DadosDoUsuario

A classe `DadosDoUsuario` é responsável por armazenar os dados do usuário, como número da conta, nome e saldo. Ela possui as seguintes propriedades públicas com acesso privado:

- `NumeroDaConta`: Obtém o número da conta.
- `Nome`: Obtém o nome do titular da conta.
- `Saldo`: Obtém o saldo da conta.

A classe também possui os seguintes métodos:

- `AdicionarSaldo(decimal a)`: Adiciona um valor ao saldo da conta.
- `SaqueSaldo(decimal a)`: Realiza um saque na conta, debitando o valor do saldo.

## Classe FormatacaoGeral

A classe `FormatacaoGeral` contém métodos utilitários para realizar formatações e verificações gerais. Ela possui os seguintes métodos estáticos:

- `FormataNumeroDaConta()`: Solicita ao usuário que digite o número da conta com 4 dígitos e realiza a validação.
- `FormataNome()`: Solicita ao usuário que digite o nome do titular da conta e realiza a validação.
- `FormatacaoSimNao(string a)`: Verifica se a entrada do usuário é "sim" ou "nao" e realiza a formatação.
- `VerificacaoNumero(string deposito)`: Verifica se a entrada do usuário é um número decimal válido.

## Classe Program

A classe `Program` é a classe principal do programa. Ela contém o método `Main` que é o ponto de entrada do programa. No método `Main`, o programa solicita ao usuário informações como número da conta, nome e se haverá um depósito inicial. Em seguida, realiza operações como adicionar saldo e fazer saques na conta, exibindo os resultados na tela.

## Como executar o programa

Para executar o programa, siga os seguintes passos:

1. Abra o projeto no Visual Studio ou em outro ambiente de desenvolvimento C#.
2. Compile o projeto para garantir que não há erros de compilação.
3. Execute o programa.
4. Siga as instruções apresentadas no console para interagir com o sistema bancário.

---

Esse é um exemplo simples de um sistema bancário em C#. Sinta-se à vontade para utilizar e modificar o código conforme necessário.
