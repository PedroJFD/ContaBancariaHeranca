using AgenciaBancariaHeranca.Classes;
using System.Net.WebSockets;
/*
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

*/



ContaEstudante a = new ContaEstudante(300, "002.213.213-21", "IFRO", 0001, 123, "Pedro Joaquim", 1);

a.Sacar(250);

Console.WriteLine(a.Saldo);

a.Depositar(100);

Console.WriteLine(a.Saldo);

ContaEmpresa b = new ContaEmpresa(10, 1000, 0, 0002, 123, "Elias", 5001);

b.Sacar(5001);

//Console.WriteLine(b.Saldo);

