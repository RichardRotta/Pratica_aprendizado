using System;

namespace Exercicios_Ademar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, v2, S; // v1 = valor 1, v2 = valor 2, s = Soma

            Console.WriteLine("Algoritimo de Soma");
            Console.WriteLine("-------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o primeiro valor:"); //Entrada valor 1
            v1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:"); //Entrada valor 2
            v2 = double.Parse(Console.ReadLine());

            S = v1 + v2; //Processamento soma

            Console.WriteLine("Sua soma é:{0}", S); //Saída da Soma
            Console.ReadKey();
            Console.WriteLine();

            // ALGORITMO PARA SOMA DE 2 NÚMEROS


            double Vh, Ht, Pf; // Vh = Valor pagamento/hora, Ht = Quantidade horas/trabalhadas, Pf = Pagamento final

            Console.WriteLine("Algoritimo de pagamento/horas trabalhadas");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o nome do empregado:"); //Entrada nome empregado
            string N = Console.ReadLine(); // N = Nome
            Console.WriteLine("Digite o valor do pagamento por hora:"); //Entrada valor hora
            Vh = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhadas"); //Entrada horas trabalhadas
            Ht = double.Parse(Console.ReadLine());

            Pf = Vh * Ht; //Processamento preço final

            Console.WriteLine("Nome: {0}", N); //Saída Nome
            Console.WriteLine("Valor por hora: {0}", Vh); //Saída valor hora
            Console.WriteLine("Horas trabalhadas: {0}", Ht); //Saída horas trabalhadas
            Console.WriteLine("O pagamento para {0} deve ser de: {1}", N, Pf); //Saída nome + pagamento final
            Console.ReadKey();
            Console.WriteLine();

            // PAGAMENTO POR HORAS TRABALHADAS


            double L, C, Vt, At, Pt; // L = Largura, C = Comprimento, Vt = Valor m² terreno, At = Área terreno, Pt = Preço terreno

            Console.WriteLine("Algoritimo da área do terreno e precificação");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite a largura do terreno:"); //Entrada Laegura
            L = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terreno:"); //Entrada Comprimento
            C = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do m² do terreno:"); //Entrada valor m² terreno
            Vt = double.Parse(Console.ReadLine());
                
            At = L * C; //Processamento área terreno
            Pt = At * Vt; //Processamento preço terreno

            Console.WriteLine("A área do terreno é: {0}", At); //Saída área terreno
            Console.WriteLine("O preço do terreno é: {0}", Pt); //Saída preço terreno
            Console.ReadKey();
            Console.WriteLine();

            // ÁREA DE UM TERRENO E O PREÇO DELE


            double i1, i2, M; // i1 = Idade 1, i2 = Idade 2, M = Média
            string n1, n2; // n1 = Nome 1, n2 = Nome 2

            Console.WriteLine("Algoritimo de média de idade");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();

            Console.WriteLine("Digite o nome da primeira pessoa:"); //Entrada nome 1
            n1 = (Console.ReadLine());
            Console.WriteLine("Digite a idade da primeria pessoa:"); //Entrada idade 1
            i1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da segunda pessoa:"); //Entrada nome 2
            n2 = (Console.ReadLine());
            Console.WriteLine("Digite a idade da segunda pessoa:"); //Entrada idade 2
            i2 = double.Parse(Console.ReadLine());

            M = (i1 + i2) / 2; //Processamento média

            Console.WriteLine();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: {0}", n1); //Saída nome 1
            Console.WriteLine("Idade: {0}", i1); //Saída idade 1

            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: {0}", n2); //Saída nome 2
            Console.WriteLine("Idade: {0}", i2); //Saída idade 2
                
            Console.WriteLine("A idade média de {0} e {1} é de {2} anos.", n1, n2, M); //Saída nome 1 + nome 2 + média
            Console.ReadKey();

            // IDADE MÉDIA ENTRE 2 PESSOAS

        }
    }
}