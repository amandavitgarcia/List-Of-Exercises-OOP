using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancariaEx
{
    public class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public double SaldoConta { get; set; }
        public string TitularConta { get; set; }
        public int IdadeTitularConta { get; set; }
        public double LimiteConta { get; set; }

        // Construtor
        public ContaBancaria(int numeroConta, double saldoConta, string titularConta, int idadeTitularConta, double limiteConta)
        {
            NumeroConta = numeroConta;
            SaldoConta = saldoConta;
            TitularConta = titularConta;
            IdadeTitularConta = idadeTitularConta;
            LimiteConta = limiteConta;
        }

        // Método sem LINQ
        public void MostraUsuarios(List<ContaBancaria> contasBancarias)
        {
            foreach (var conta in contasBancarias)
            {
                // Checando se o saldo é maior que 10000 e checando se o nome do titular da conta não(!) contem as strings informadas 
                if (conta.SaldoConta > 10000 && !conta.TitularConta.Contains("S/A") && !conta.TitularConta.Contains("LTDA"))
                {
                    Console.WriteLine($"Nome Titular: {conta.TitularConta} \t Número da Conta: {conta.NumeroConta} \t Saldo: {conta.SaldoConta}");
                }
            }
        }

        // Método usando LINQ
        public void MostraUsuariosLinq(List<ContaBancaria> contasBancarias)
        {
            var verificacaoRetorno = contasBancarias.Where(conta => conta.SaldoConta > 10000 && !conta.TitularConta.Contains("S/A") && !conta.TitularConta.Contains("LTDA")).ToList();

            foreach (var conta in verificacaoRetorno)
            {
                Console.WriteLine($"Nome Titular: {conta.TitularConta} \t Número da Conta: {conta.NumeroConta} \t Saldo: {conta.SaldoConta}");
            }
        }
    }
}
