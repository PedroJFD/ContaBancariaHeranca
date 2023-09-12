using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancariaHeranca.Classes
{
    internal class ContaEmpresa:ContaBancaria
    {

        public double TaxaAnuidade { get; set; }
        public double LimiteEmprestimo { get; set; }
        public double TotalEmprestimo { get; set; }

        public ContaEmpresa(double taxaAnuidade, double limiteEmprestimo, double totalEmprestimo, int numConta, int agencia, string titularConta, double saldo) : base(numConta, agencia, titularConta, saldo)
        {
            TaxaAnuidade = taxaAnuidade;
            LimiteEmprestimo = limiteEmprestimo;
            TotalEmprestimo = totalEmprestimo;
        }

        public void Emprestimo(double valorEmprestimo)
        {
            if(valorEmprestimo <= LimiteEmprestimo)
            {
                TotalEmprestimo = valorEmprestimo - TotalEmprestimo;
            }
            else
            {
                Console.WriteLine("O valor de empréstimo não pode ser concedido.");
            }
        }

        public override void Sacar(double valor)
        {
            if(valor > 5000)
            {
                if (valor <= Saldo)
                {
                    Saldo = Saldo - valor -5;
                    Console.WriteLine($"Você sacou {valor} reais, -5 reais no saldo de taxa.");
                }
                else
                {
                    Console.WriteLine("Você não tem saldo suficiente.");
                }
            }
            else
            {
                if (valor <= Saldo)
                {
                    Saldo = Saldo - valor;
                    Console.WriteLine($"Você sacou {valor} reais.");
                }
                else
                {
                    Console.WriteLine("Você não tem saldo suficiente.");
                }
            }
        }
    }
}
