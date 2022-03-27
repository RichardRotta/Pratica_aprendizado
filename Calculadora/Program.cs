using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double n1 = 0, n2 = 0, a, s, m, d; // n1 = Número 1,  n2 = Número 2, a = Adição, s = Subtração, m = Multiplicação, d = Divisão

            Console.WriteLine("*** Calculadora Simples ***"); // Nome do programa
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            Console.WriteLine("Bem vindo(a) a calculadora simples!!! Clique enter para prosseguir."); //Apresentação
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro número:"); //Entrada número 1
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:"); //Entrada número 2
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o operador desejado, sendo:");
            Console.WriteLine("\tm = Multiplicação");
            Console.WriteLine("\td = Divisão");
            Console.WriteLine("\ta = Adição");
            Console.WriteLine("\ts = Subtração");
            Console.WriteLine();
            Console.WriteLine("Digite sua escolha:"); //Entrada operador

            a = n1 + n2; //Processamento adição
            s = n1 - n2; //Processamento subtração
            m = n1 * n2; //Processamento multiplicação
            d = n1 / n2; //Processamento divisão

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Seu resultado é {0} + {1} = {2}", n1, n2, a); //Saída resultado adição
                break;

                case "s":
                    Console.WriteLine("Seu resultado é {0} - {1} = {2}", n1, n2, s); //Saída resultado subtração
                    break;

                case "m":
                    Console.WriteLine("Seu resultado é {0} * {1} = {2}", n1, n2, m); //Saída resultado mutiplicação
                    break;

                case "d":
                    Console.WriteLine("Seu resultado é {0} / {1} = {2}", n1, n2, d); //Saída resultado divisão
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Aperte enter para sair.");
            Console.ReadKey();

           
        }
    }
}
