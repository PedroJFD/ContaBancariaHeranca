using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancariaHeranca.Classes
{
    internal class ContaBancaria
    {
        public int NumConta { get; set; }
        public int Agencia { get; set; }
        public string TitularConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numConta, int agencia, string titularConta, double saldo) {

            NumConta = numConta;
            Agencia = agencia;
            TitularConta = titularConta;
            Saldo = saldo;
        
        }

        public virtual void Sacar(double valor)
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

        public virtual void Depositar(double valor)
        {
            Saldo = Saldo + valor;
            Console.WriteLine($"Você depositou!");
        }
    }
}
