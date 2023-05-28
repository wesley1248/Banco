using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    internal class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa iniciado!.");

            //solicitação para digitar o numero da conta e demais verificações
            int aNumeroDaConta = FormatacaoGeral.FormataNumeroDaConta();

            //solicitação para digitar o Nome do Titular da conta e demais verificações
            string nome = FormatacaoGeral.FormataNome();
            DadosDoUsuario usuario = new DadosDoUsuario(aNumeroDaConta, nome, 000);

            //Entrada de saldo ou não
            Console.Write("Haverá deposito inicial? Sim/Não: ");
            string acao = Console.ReadLine();
            //Verificação de Sim ou Não e formatação de caracteres especiais
            acao = FormatacaoGeral.FormatacaoSimNao(acao);
            Console.WriteLine();

            //Analise da entrada
            switch (acao)
            {
                case "nao":

                    Console.WriteLine("Dados da conta:");
                    Console.Write("Conta " + usuario.NumeroDaConta + "  Titular: " + usuario.Nome + "  Saldo: $" + usuario.Saldo.ToString("F2") + ".");

                    Console.WriteLine();
                    Console.Write("Entre com um valor para o deposito: ");
                    string deposito = Console.ReadLine();

                    //Verifica se a entrada do usuario é um decimal valido 
                    decimal depositoValido = FormatacaoGeral.VerificacaoNumero(deposito);

                    //Método para adicionar o valor ao saldo da conta
                    usuario.AdicionarSaldo(depositoValido);
                    Console.WriteLine();

                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine("Conta " + usuario.NumeroDaConta + "  Titular: " + usuario.Nome + "  Saldo: $" + usuario.Saldo.ToString("F2") + ".");
                    Console.WriteLine();

                    Console.WriteLine("Atenção, para cada saque é cobrado um valor de $5,00");
                    Console.Write("Entre com um valor para saque: ");
                    string valorSaque = Console.ReadLine();
                    //Verificação de numero valido
                    decimal saqueValido = FormatacaoGeral.VerificacaoNumero(valorSaque);

                    //Debita valores da conta
                    usuario.SaqueSaldo(saqueValido);

                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine("Conta " + usuario.NumeroDaConta + "  Titular: " + usuario.Nome + "  Saldo: $" + usuario.Saldo.ToString("F2") + ".");

                    break;

                case "sim":

                    Console.Write("Entre com o valor para deposito: ");
                    string auxiliarValorDeposito = Console.ReadLine();

                    //Verificação de numero 
                    decimal validoDepositoInicial = FormatacaoGeral.VerificacaoNumero(auxiliarValorDeposito);

                    //Adiciona o saldo
                    usuario.AdicionarSaldo(validoDepositoInicial);
                    Console.WriteLine();

                    Console.WriteLine("Dados da conta atualizados:");
                    Console.WriteLine("Conta " + usuario.NumeroDaConta + "  Titular: " + usuario.Nome + "  Saldo: $" + usuario.Saldo.ToString("F2") + ".");
                    Console.WriteLine();

                    Console.WriteLine("Atenção, para cada saque é cobrado um valor de $5,00");
                    Console.Write("Entre com um valor para saque: ");
                    string valorSaque2 = Console.ReadLine();

                    //Verifica o numero
                    decimal saqueValido2 = FormatacaoGeral.VerificacaoNumero(valorSaque2);

                    //Debita valores da conta
                    usuario.SaqueSaldo(saqueValido2);
                    Console.WriteLine();

                    Console.WriteLine("Dados da conta atualizados:");
                    Console.Write("Conta " + usuario.NumeroDaConta + "  Titular: " + usuario.Nome + "  Saldo: $" + usuario.Saldo.ToString("F2") + ".");

                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Tecle Enter para finalizar");
            Console.ReadKey();
        }
    }
}
