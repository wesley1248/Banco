using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Banco {
    internal class DadosDoUsuario {

        // Propriedades públicas com acesso privado para encapsulamento dos dados
        public int NumeroDaConta
        {
            get; private set;
        }
        public string Nome
        {
            get; private set;
        }
        public decimal Saldo
        {
            get; private set;
        }

        // Construtor vazio
        public DadosDoUsuario()
        {
        }

        // Construtor com parâmetros para inicialização dos dados do usuário
        public DadosDoUsuario(int NumeroDaConta, string Nome, decimal Saldo)
        {
            this.NumeroDaConta = NumeroDaConta;
            this.Nome = Nome;
            this.Saldo = Saldo;
        }

        // Método para adicionar saldo na conta
        public void AdicionarSaldo(decimal a)
        {
            // Adiciona o saldo na conta
            Saldo = Saldo + a;
        }

        // Método para realizar um saque na conta
        public void SaqueSaldo(decimal a)
        {
            // Debita valores da conta e verifica saldo
            Saldo = Saldo - a - 5;

            if (Saldo == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Ops, você está sem saldo!");
            }
            else if (Saldo < 0)
            {
                Console.WriteLine();
                Console.WriteLine("Atenção, você está negativado");
            }
        }
    }
}



