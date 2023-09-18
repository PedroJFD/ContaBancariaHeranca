using AgenciaBancariaHeranca.Classes;
using System;

class Program
{
    static void Main(string[] args)
    {
        int escolha = 0;
        int escolha2 = 0;
        int escolha3 = 0;
        
        Console.WriteLine("Selecione o tipo de conta:\nConta Estudante - 1\nConta Empresarial - 2");
        Console.Write("\nEscolha: ");
        escolha = Convert.ToInt32(Console.ReadLine());
        try
        {
            switch (escolha)
            {
                case 1:
                    Console.Write("\nDigite seu nome: ");
                    string titularConta = Console.ReadLine();

                    Console.Write("\nDigite seu CPF: ");
                    string cpf = Console.ReadLine();

                    Console.Write("\nDigite o Nome da sua Instituicao: ");
                    string nomeinstituicao = Console.ReadLine();
                    ContaEstudante a = new ContaEstudante(100, cpf, nomeinstituicao, 001, 007, titularConta, 0);

                    while (true)
                    {
                        Console.WriteLine("\nDeseja movimentar algo?\nSim - 1\nNao - 2");
                        Console.Write("\nEscolha: ");
                        escolha3 = Convert.ToInt32(Console.ReadLine());

                        if (escolha3 == 1)
                        {
                            Console.WriteLine("\nO que deseja movimentar?\nSacar - 1\nDepositar - 2");
                            Console.Write("Escolha: ");
                            escolha2 = Convert.ToInt32(Console.ReadLine());
                            switch (escolha2)
                            {
                                case 1:
                                    Console.Write("\nDigite Valor para sacar: ");
                                    double valor = Convert.ToDouble(Console.ReadLine());
                                    a.Sacar(valor);
                                    break;

                                case 2:
                                    Console.Write("\nDigite Valor para depositar: ");
                                    double valor2 = Convert.ToDouble(Console.ReadLine());
                                    a.Depositar(valor2);
                                    break;

                                default:
                                    Console.WriteLine("Escolha Invalida!");
                                    break;
                            }
                        }
                        else if (escolha3 == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Escolha Invalida!");
                        }
                    }
                    break;//case 1 break

                case 2:
                    Console.Write("\nDigite seu nome: ");
                    string titularConta2 = Console.ReadLine();
                    ContaEmpresa b = new ContaEmpresa(10, 5000, 0, 001, 007, titularConta2, 0);

                    while (true)
                    {
                        Console.WriteLine("\nDeseja movimentar algo?\nSim - 1\nNao - 2");
                        Console.Write("\nEscolha: ");
                        escolha3 = Convert.ToInt32(Console.ReadLine());
                        if (escolha3 == 1)
                        {
                            Console.WriteLine("\nO que deseja movimentar?\nSacar - 1\nDepositar - 2\nEmprestimo - 3");
                            Console.Write("\nEscolha: ");
                            escolha2 = Convert.ToInt32(Console.ReadLine());
                            switch (escolha2)
                            {
                                case 1:
                                    Console.Write("\nDigite Valor para sacar: ");
                                    double valor = Convert.ToDouble(Console.ReadLine());
                                    b.Sacar(valor);
                                    break;

                                case 2:
                                    Console.Write("\nDigite Valor para depositar: ");
                                    double valor2 = Convert.ToDouble(Console.ReadLine());
                                    b.Depositar(valor2);
                                    break;

                                case 3:
                                    Console.Write("\nDigite Valor para tentar emprestimo: ");
                                    double valor3 = Convert.ToDouble(Console.ReadLine());
                                    b.Emprestimo(valor3);
                                    break;

                                default:
                                    Console.WriteLine("Escolha Invalida!");
                                    break;
                            }
                        }
                        else if (escolha3 == 2)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Escolha Invalida!");
                        }
                    }
                    break;//case 2 break

                default: 
                    Console.WriteLine("Escolha Invalida!");
                    break;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex);
        }
    }
}
