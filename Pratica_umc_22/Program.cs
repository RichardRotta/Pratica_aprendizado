
using System;

namespace CalcAritmético
{
    internal class Program
    {
        static void Main(string[] args)

        { // INICIO

            // CÁLCULO DE MÉDIA

            /*double n1 = 0, n2 = 0, n3 = 0, M = 0; // Variaveis

            Console.WriteLine("Calculo Aritmético da média"); // Nome do Programa
            
                Console.WriteLine("Coloque sua nota 1:");
                n1 = double.Parse(Console.ReadLine()); // Ler n1 (Entrada)

                Console.WriteLine("Coloque sua nota 2:");
                n2 = double.Parse(Console.ReadLine()); // Ler n2 (Entrada)

                Console.WriteLine("Coloque sua nota 3:");
                n3 = double.Parse(Console.ReadLine()); // Ler n3 (Entrada)

            M = (n1 + n2 + n3) / 2; // Expressão Aritmética (Processamento)

                Console.WriteLine("Sua média é: {0}", M); // Resultado (Saída)

            if (M >= 6) // Se M for >= 3
            {
                Console.WriteLine("Você foi Aprovado"); // Escreva "Você foi Aprovado"
            }
            else // Senão
            {
                if (M >= 3) // Se M for >= 3
                {
                    Console.WriteLine("Você tem que fazer o Exame"); // Escreva "Você tem que fazer o Exame"
                }
                 else // Senão
                {
                    Console.WriteLine("Você foi Reprovado"); // Escreva "Você foi Reprovado"
                }
            }
            
            Console.ReadKey(); // Pausar a tela */


            //CATEGORIA DE IDADE

            /*float idade = 0;

            Console.WriteLine("Categoria de Idades");

            Console.WriteLine("Coloque sua Idade");
            idade = float.Parse(Console.ReadLine());
            if (idade <= 0)
            {
                Console.WriteLine("Idade invalida");
            }
            else
            {
                if (idade < 18)
                {
                    Console.WriteLine("Menor de Idade");
                }
                else
                {
                    if (idade <= 64)
                    {
                        Console.Write("Maior de Idade");
                    }
                    else
                    {
                        Console.WriteLine("Idoso");
                    }
                }
            }*/

            // SALáRIO + COMISSÃO

            double S = 0, Sf = 0, C = 0;

            Console.WriteLine("Cálculo do salário + comissão");

            Console.WriteLine("Coloque seu salário");
            S = double.Parse(Console.ReadLine());

            if (S < 750)
            {
                Sf = S + 100;
                C = 100;
            }
            else
            {
                if (S < 1500)
                {
                    Sf = S + 50;
                    C = 50;
                }
                else
                {
                    if (S > 1500)
                    {
                        Sf = S + 25;
                        C = 25;
                    }
                }
            }

            Console.WriteLine("Seu salário + comissão é: {0}", Sf);
            Console.WriteLine("Sua comissão é de: {0}", C);

            Console.ReadKey();

        } // FIM
    }
}
