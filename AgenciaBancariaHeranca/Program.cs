using AgenciaBancariaHeranca.Classes;
using System;

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria c = new ContaBancaria(1, 1, "Elias", 00);
        Console.WriteLine($"O saldo da conta é {c.Saldo}");

        Console.WriteLine("Digite o valor de depósito");
        double valorO = Convert.ToDouble(Console.ReadLine());
        c.Depositar(valorO);
        Console.WriteLine($"O saldo é {c.Saldo}");


        Console.WriteLine("Digite o valor de saque");
        valorO = Convert.ToDouble(Console.ReadLine());
        c.Sacar(valorO);
        Console.WriteLine($"O saldo é {c.Saldo}");
    }
}
