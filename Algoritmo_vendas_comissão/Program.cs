
using System;

namespace Vendas_Comissão
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double V = 0, S = 0, Sf = 0, C = 0; // V = Vendas, S = Salário, Sf = Salário + Comissão, C = Comissão;
            string nome;

            Console.WriteLine("Digite o seu nome:"); // Entrada Nome
            nome = (Console.ReadLine());

            Console.WriteLine("Seja Bem Vindo, Sr(a) {0}!", nome); // Saída Nome + Recepção
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Digite suas vendas desse mês:"); // Entrada vendas
            V = double.Parse(Console.ReadLine());
            S = 1750; // Difinição Salário

            if (V <= 6999.99) //Condição
            {
                Sf = (V * 0.05) + S;
                C = (V * 0.05);
            }
            else
            {
                if (V <= 9999.99) //Condição
                {
                    Sf = (V * 0.07) + S;
                    C = (V * 0.07);
                }
                else
                {
                    if (V >= 10000) //Condição
                    {
                        Sf = (V * 0.1) + S;
                        C = (V * 0.1);
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sua comissão esse mês, foi de: {0}", C); //Saída comissão
            Console.WriteLine("Seu salário final é: {0}", Sf); // Saída salário final
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("Tenha um ótimo dia, Sr(a) {0}!", nome); // Agradecimento final
            Console.ReadKey();
        }
    }
}
