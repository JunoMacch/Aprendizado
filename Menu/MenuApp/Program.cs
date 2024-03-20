using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OpcaoMenu opcao = new OpcaoMenu();
            
            do
            {
                opcao.ExibirMenu();
                opcao.Escolha = int.Parse(Console.ReadLine());

                switch (opcao.Escolha)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Programa Número Par/Ímpar");
                        Console.Write("Insira um número para verificar se ele é Ímpar ou Par: ");
                        opcao.Num = int.Parse(Console.ReadLine());
                        opcao.ParImpar(opcao.Num);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Programa Tabuada");
                        Console.Write("Insira um número para fazer a tabuada: ");
                        opcao.Num = int.Parse(Console.ReadLine());
                        opcao.Tabuada(opcao.Num);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Programa Número Primo");
                        Console.Write("Por favor insira um numero para verificarmos se ele é primo: ");
                        opcao.Num = int.Parse(Console.ReadLine());
                        opcao.NumeroPrimo(opcao.Num);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Programa Sequência Fibonacci");
                        Console.Write("Insira até qual termo você deseja que a sequência de Fibonacci vá: ");
                        opcao.Num = int.Parse(Console.ReadLine());
                        opcao.NumeroFibonacci(opcao.Num);
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Programa Fatorial");
                        opcao.Num = int.Parse (Console.ReadLine());
                        opcao.Fatorial(opcao.Num);
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        if (opcao.Escolha != 0)
                        {
                            Console.WriteLine("Por favor escolha uma opção válida");
                            Console.WriteLine("Pressione qualquer tecla para continuar!");
                            Console.ReadKey();
                        }
                        break;
                }
            } while (opcao.Escolha != 0);
        }
    }
}
