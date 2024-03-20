using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
                        do
                        {
                            Console.Clear();
                            Console.Title = "Programa Número Par/Ímpar";
                            Console.WriteLine("Programa Número Par/Ímpar");
                            Console.Write("Insira um número para verificar se ele é Ímpar ou Par: ");
                            opcao.Num = int.Parse(Console.ReadLine());
                            if (opcao.Num < 0)
                            {
                                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                                Console.WriteLine("Pressione qualquer tecla para inserir um número!");
                                Console.ReadKey();
                            }
                        } while (opcao.Num < 0);
                        opcao.ParImpar(opcao.Num);
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
                        Console.ReadKey();
                        break;
                    case 2:
                        do
                        { 
                            Console.Clear();
                            Console.Title = "Programa Tabuada";
                            Console.WriteLine("Programa Tabuada");
                            Console.Write("Insira um número para fazer a tabuada: ");
                            opcao.Num = int.Parse(Console.ReadLine());
                            if (opcao.Num < 0)
                            {
                                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                                Console.WriteLine("Pressione qualquer tecla para inserir um número!");
                                Console.ReadKey();
                            }
                        } while (opcao.Num < 0);
                        opcao.Tabuada(opcao.Num);
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
                        Console.ReadKey();
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.Title = "Programa Número Primo";
                            Console.WriteLine("Programa Número Primo");
                            Console.Write("Por favor insira um numero para verificarmos se ele é primo: ");
                            opcao.Num = int.Parse(Console.ReadLine());
                            if (opcao.Num < 0)
                            {
                                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                                Console.WriteLine("Pressione qualquer tecla para inserir um número!");
                                Console.ReadKey();
                            }
                        } while (opcao.Num < 0);
                        opcao.NumeroPrimo(opcao.Num);
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
                        Console.ReadKey();
                        break;
                    case 4:
                        do
                        {
                            Console.Clear();
                            Console.Title = "Programa Sequência Fibonacci";
                            Console.WriteLine("Programa Sequência Fibonacci");
                            Console.Write("Insira até qual termo você deseja que a sequência de Fibonacci vá: ");
                            opcao.Num = int.Parse(Console.ReadLine());
                            if (opcao.Num < 0)
                            {
                                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                                Console.WriteLine("Pressione qualquer tecla para inserir um número!");
                                Console.ReadKey();
                            }
                        } while (opcao.Num < 0);
                        opcao.NumeroFibonacci(opcao.Num);
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
                        Console.ReadKey();
                        break;
                    case 5:
                        do
                        {
                            Console.Clear();
                            Console.Title = "Programa Fatorial";
                            Console.WriteLine("Programa Fatorial");
                            Console.Write("Por favor insira um número para calcularmos o seu fatorial: ");
                            opcao.Num = int.Parse (Console.ReadLine());
                            if (opcao.Num < 0)
                            {
                                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                                Console.WriteLine("Pressione qualquer tecla para inserir um número!");
                                Console.ReadKey();
                            }
                        } while (opcao.Num < 0);
                        opcao.Fatorial(opcao.Num);
                        Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
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
            Console.WriteLine(@"
            ████████╗░█████╗░██╗░░██╗░█████╗░██╗░░░██╗  ████████╗░█████╗░██╗░░██╗░█████╗░██╗░░░██╗
            ╚══██╔══╝██╔══██╗██║░░██║██╔══██╗██║░░░██║  ╚══██╔══╝██╔══██╗██║░░██║██╔══██╗██║░░░██║
            ░░░██║░░░██║░░╚═╝███████║███████║██║░░░██║  ░░░██║░░░██║░░╚═╝███████║███████║██║░░░██║
            ░░░██║░░░██║░░██╗██╔══██║██╔══██║██║░░░██║  ░░░██║░░░██║░░██╗██╔══██║██╔══██║██║░░░██║
            ░░░██║░░░╚█████╔╝██║░░██║██║░░██║╚██████╔╝  ░░░██║░░░╚█████╔╝██║░░██║██║░░██║╚██████╔╝
            ░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░  ░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝░╚═════╝░
            ======================================================================================
            ");
            Thread.Sleep(1000);
        }
    }
}
