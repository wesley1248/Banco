using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Banco {
    public class FormatacaoGeral {
        public static int FormataNumeroDaConta()
        {
            //A entrada do usuario tem que ser um numero e conter 4 algarismos
            int numero;
            bool validacao = false;

            do
            {
                Console.Write("Digite o numero da sua conta com 4 dígitos: ");
                string entrada = Console.ReadLine();
                // Verifica se a entrada é um número válido e possui 4 dígitos
                if (int.TryParse(entrada, out numero) && entrada.Length == 4)
                {
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Numero invalido, digite novamente!");
                }
            } while (!validacao);
            return numero;
        }

        public static string FormataNome()
        {
            CultureInfo cultureInfo = CultureInfo.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            string nome;
            Regex regex = new Regex("[a-zA-Z]+$");

            do
            {
                Console.Write("Digite o nome do titular da conta: ");
                nome = Console.ReadLine();

                // Verifica se a entrada contém somente letras
                if (!regex.IsMatch(nome))
                {
                    Console.WriteLine("Entrada inválida, digite somente letras.");
                }
            } while (!regex.IsMatch(nome));

            // Separa o nome em palavras utilizando o espaço como delimitador
            string[] palavras = nome.Split(' ');

            for (int i = 0; i < palavras.Length; i++)
            {
                // Converte a primeira letra de cada palavra para maiúscula
                palavras[i] = textInfo.ToTitleCase(palavras[i]);
            }

            // Junta as palavras formatadas novamente em uma string
            string nomeFormatado = string.Join(" ", palavras);

            return nomeFormatado;
        }

        public static string FormatacaoSimNao(string a)
        {
            bool valida = false;

            do
            {
                //A entrada do usuario deve ser Sim ou Não
                if (a == "sim" || a == "nao")
                {
                    valida = true;
                }
                else
                {
                    Console.Write("Ops, digite Sim ou Não: ");
                    a = Console.ReadLine();
                }
            } while (!valida);

            // Remoção de acentos
            string entradaSemAcento = new string(
                a.Normalize(NormalizationForm.FormD)
                    .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                    .ToArray());

            // Conversão para letras minúsculas
            string resultadoFormatado = entradaSemAcento.ToLower();

            return resultadoFormatado;
        }

        public static decimal VerificacaoNumero(string deposito)
        {
            decimal b;
            bool validacao = false;

            // Loop de validação para garantir que o valor digitado seja um número decimal válido
            do
            {
                if (decimal.TryParse(deposito, out b))
                {
                    validacao = true;
                }
                else
                {
                    Console.WriteLine("Número inválido, digite novamente!");
                    Console.Write("Digite o valor: ");
                    deposito = Console.ReadLine();
                }
            } while (!validacao);

            // Retorna o valor decimal válido
            return b;
        }

    }

}

