using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancariaHeranca.Classes
{
    internal class ContaEstudante:ContaBancaria
    {
        public double LimiteChequeEspecial { get; set; }
        public string CPF { get; set; }
        public string NomeInstituicao { get; set; }


        public ContaEstudante(double limiteChequeEspecial, string cpf, string nomeinstituicao, int numConta, int agencia, string titularConta, double saldo) : base(numConta, agencia, titularConta, saldo)
        {
            LimiteChequeEspecial = limiteChequeEspecial;
            CPF = cpf;
            NomeInstituicao = nomeinstituicao;
        }

        public override void Sacar(double valor)
        {
            if (valor <= Saldo + LimiteChequeEspecial)
            {
                Console.WriteLine($"Você sacou {valor} reais.");
                Saldo = Saldo - valor;
            }
            else
            {
                Console.WriteLine("Você não tem saldo suficiente.");
            }
        }
    }
}
