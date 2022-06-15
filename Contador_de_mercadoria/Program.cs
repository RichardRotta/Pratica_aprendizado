using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contador_de_mercadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PROGRAMA: Contador de mercadoria;
             * PROBLEMA: Fazer a soma de todos os produtos selecionados, e mostrar o total no final;
             * DATA: 29/05/2022
             * AUTOR: Richard Rotta
             */

            int i=0;
            double valor, total = 0;
            string resposta = "sim";
            
            while (resposta == "sim" || resposta == "s")
            {
                Console.Write("Digite o valor do produto: ");
                valor = double.Parse(Console.ReadLine());

                total = valor + total;

                Console.Write("Possui mais algum produto?: ");
                resposta = Console.ReadLine();

                i++;

                Console.Clear();
            }

            Console.Write("Total: ");
            Console.Write(total.ToString("C"));
            Console.WriteLine("\nQuantidade de produto(s): {0}", i);

            Console.ReadKey();

        }
    }
}
