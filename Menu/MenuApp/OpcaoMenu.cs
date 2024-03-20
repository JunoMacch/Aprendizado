using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MenuApp
{
    internal class OpcaoMenu
    {
        public int Escolha { get; set; }
        public int Num { get; set; }


        public void ExibirMenu()
        {
            Console.Title = "Menu App";
            Console.Clear();
            Console.WriteLine(@"
                                ███╗░░░███╗███████╗███╗░░██╗██╗░░░██╗
                                ████╗░████║██╔════╝████╗░██║██║░░░██║
                                ██╔████╔██║█████╗░░██╔██╗██║██║░░░██║
                                ██║╚██╔╝██║██╔══╝░░██║╚████║██║░░░██║
                                ██║░╚═╝░██║███████╗██║░╚███║╚██████╔╝
                                ╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚══╝░╚═════╝░
                                =====================================
            ");
            Console.WriteLine("[1] - Programa Número Par/Ímpar");
            Console.WriteLine("[2] - Programa Tabuada");
            Console.WriteLine("[3] - Programa Número Primo");
            Console.WriteLine("[4] - Programa Sequência Fibonacci");
            Console.WriteLine("[5] - Programa Fatorial");
            Console.WriteLine("[0] - Finalizar");
        }


        public int ParImpar(int num)
        {   
            if (num % 2 == 0)
            {
                Console.WriteLine($"O número {num} é par");
            }
            else
            {
                Console.WriteLine($"O número {num} é ímpar");
            }
            return num;
        }

        public int Tabuada(int num)
        {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}x{i} = {num * i}");
                }
            return num;
        }

        public int NumeroPrimo(int num)
        {
            int cont = 1;

            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            
            if (cont == 2)
            {
                Console.WriteLine($"O número {num} é primo");
            }
            else
            {
            Console.WriteLine($"O número {num} não é primo");
            }
            
            return num;
        }

        public int NumeroFibonacci(int num)
        {
            
            int a = 0, b = 1, c;

            for (int cont = 1; cont <= num; cont++)
            {
                Console.Write($"{a}, ");
                c = a + b;
                a = b;
                b = c;
            }
            
            return num;
        }

        public int Fatorial(int num)
        {
            int fatorial = num;
            if ( fatorial == 0)
            {
                Console.WriteLine($"O fatorial de {num} é 1");
            } else
            {
                for (int i = num - 1; i > 1; i--)
                {
                    Console.WriteLine($"{num}x{i} = {num *= i}");
                }

                Console.WriteLine($"O Fatorial de {fatorial} é {num}");
            }

            return num;
        }
    }
}
