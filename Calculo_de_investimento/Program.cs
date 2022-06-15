using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_de_investimento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PROJETO: CALCULO DE INVESTIMENTO
             * PROBLEMA: PEGAR O VALOR DO INVESTIMENTO, O TEMPO INVESTIDO E O VALOR DO JUROS E MOSTRAR O VALOR FINAL
             * DATA: 07/06/2022
             * AUTORES: RICHARD ROTTA, GABRIEL MOREIRA E GABRIEL 2
             */

            double valor_ini, juros, temp_invest, juros_final; //variáveis
            string j_escolhido = "", pergunta = ""; //variáveis

            while (pergunta == "S" || pergunta == "SIM" || pergunta == "")
            {
                Console.WriteLine("=======================================");
                Console.WriteLine("\tCALCULO DE INVESTIMENTO"); //título
                Console.WriteLine("=======================================");

                Console.WriteLine("\nQual o tipo de investimento? Escolha uma das opções a seguir!");
                Console.WriteLine("\t1 - Calculo de juros simples");
                Console.WriteLine("\t2 - Calculo de juros composto");
                Console.Write("Digite o número do calculo desejado: ");
                j_escolhido = Console.ReadLine(); //entrada

                if (j_escolhido != "1" && j_escolhido != "2" || j_escolhido == "")
                {
                    while (j_escolhido != "1" && j_escolhido != "2" || j_escolhido == "")
                    {
                        Console.WriteLine("Valor incorreto!");
                        Console.Write("Digite apenas o número descrito na tabela: ");
                        j_escolhido = Console.ReadLine(); //entrada
                    } //while
                } //if

                Console.Clear();

                switch (j_escolhido) //entrada
                {
                    case "1":
                        Console.WriteLine("=======================================");
                        Console.WriteLine("\tCALCULO DE JUROS SIMPLES"); //título
                        Console.WriteLine("=======================================");

                        Console.Write("Digite o valor inicial do investimento: ");
                        valor_ini = double.Parse(Console.ReadLine()); //entrada
                        Console.Write("Digite o valor da taxa juros mensal: ");
                        juros = double.Parse(Console.ReadLine()); //entrada
                        Console.Write("Digite a quantidade de meses do dinheiro aplicado: ");
                        temp_invest = double.Parse(Console.ReadLine()); //entrada

                        juros_final = valor_ini * (juros / 100) * temp_invest; //processamento

                        Console.Write("\nRentabilidade: ");
                        Console.Write(juros_final.ToString("C")); //saída

                        break;

                    case "2":
                        Console.WriteLine("=======================================");
                        Console.WriteLine("\tCALCULO DE JUROS COMPOSTO"); //título
                        Console.WriteLine("=======================================");

                        Console.Write("Digite o valor inicial do investimento: ");
                        valor_ini = double.Parse(Console.ReadLine()); //entrada
                        Console.Write("Digite o valor da taxa juros mensal: ");
                        juros = double.Parse(Console.ReadLine());
                        Console.Write("Digite a quantidade de meses do dinheiro aplicado: ");
                        temp_invest = double.Parse(Console.ReadLine());

                        juros_final = valor_ini * Math.Pow((1 + (juros / 100)), temp_invest) - valor_ini; //processamento

                        Console.Write("\nRentabilidade: ");
                        Console.Write(juros_final.ToString("C")); //saída

                        break;
                } //switch

                //while (pergunta == "")
                {
                    Console.Write("\nDeseja realizar um novo calculo? Sim ou Não?: ");
                    pergunta = Console.ReadLine(); //entrada
                    pergunta = pergunta.ToUpper();
                } //while
                Console.Clear();
            } //while
        }
    }
}
