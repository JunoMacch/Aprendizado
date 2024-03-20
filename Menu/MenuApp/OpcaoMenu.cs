using System;
using System.Collections.Generic;
using System.Linq;
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
            if (num < 0)
            {
                Console.WriteLine("Por favor insira um numero inteiro positivo!");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            }else if (num % 2 == 0)
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
            if (num < 0)
            {
                Console.WriteLine("Por favor use apenas números positivos");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            }
            else
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}x{i} = {num * i}");
                }
            }
            return num;
        }

        public int NumeroPrimo(int num)
        {
            int cont = 1;
            if (num < 0)
            {
                Console.WriteLine("Por favor use apenas números positivos");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            }
            else
            {
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
            }
            return num;
        }

        public int NumeroFibonacci(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Por favor insira um numero de termos validos");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            }
            else
            {
                int a = 0, b = 1, c;

                for (int cont = 1; cont <= num; cont++)
                {
                    Console.Write($"{a}, ");
                    c = a + b;
                    a = b;
                    b = c;
                }
            }
            return num;
        }

        public int Fatorial(int num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Por favor insira um número inteiro positivo");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu!");
            }
            else
            {
                for (int i = num - 1; i > 1; i--)
                {
                    num *= i;
                    Console.WriteLine(num);
                }
            }
            return num;
        }
    }
}
