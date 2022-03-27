using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulário_de_inscrição
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome, email, emprego_dese;
            decimal cpf, rg, tel, cel, dia_nasc, mes_nasc, ano_nasc;

            Console.WriteLine("\t\t\t\t\t*** Formulário De Incrição ***"); //cabeçalho
            Console.WriteLine("\t\t\t\t\t-------------------------------");
            Console.WriteLine();

            Console.WriteLine("Dados Pessoais:");
            Console.WriteLine("---------------");
            Console.WriteLine();
            Console.Write("Nome Completo: "); //entrada nome
            nome = Console.ReadLine();
            Console.Write("RG: "); //entrada rg
            rg = decimal.Parse(Console.ReadLine());
            Console.Write("CPF: "); //entrada cpf
            cpf = decimal.Parse(Console.ReadLine());
            Console.Write("Dia de Nascimento: "); //entrada dia de nascimento
            dia_nasc = decimal.Parse(Console.ReadLine());
            Console.Write("Mês de Nascimento: "); //entrada mês de nascimento
            mes_nasc = decimal.Parse(Console.ReadLine());
            Console.Write("Ano de Nascimento: "); //entrada ano de nascimento
            ano_nasc = decimal.Parse(Console.ReadLine());
            Console.Write("Telefone: "); //entrada telefone
            tel = decimal.Parse(Console.ReadLine());
            Console.Write("Celular: "); //entrada celular
            cel = decimal.Parse(Console.ReadLine());
            Console.Write("Email: "); //entrada email
            email = Console.ReadLine();
            Console.Write("Emprego Desejado: "); //entrada emprego desejado
            emprego_dese = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Formulário preenchido, aperte enter para confirma-lo.");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Revisão do Formulario:");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.Write("Nome: {0}", nome); //saída nome
            Console.Write("\tRG: {0}", rg); //saída rg
            Console.Write("\tCPF: {0}", cpf); //saída cpf
            Console.Write("\tData de Nascimento: {0}/{1}/{2}", dia_nasc, mes_nasc, ano_nasc); //saída data de nascimento
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Telefone: {0}", tel); //saída telefone
            Console.Write("\tCelular: {0}", cel); //saída celular
            Console.Write("\tEmail: {0}", email); //saída email
            Console.Write("\tEmprego Desejado: {0}", emprego_dese); //saída emprego desejado
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("O formulário está correto?");
            Console.WriteLine("Digite s para enviar, ou, n para corrigir"); //Entrada s e n

            switch (Console.ReadLine()) //condição
            {
                case "s":
                    Console.WriteLine();
                    Console.WriteLine("Formulário enviado, boa sorte!"); //Saída mensagem
                    Console.WriteLine();
                    break;
                case "n":
                    Console.WriteLine();
                    Console.WriteLine("Lamentamos o transtorno, peço que recarregue a página e refaça o formulário."); //Saída mensagem
                    Console.WriteLine();
                    break;
            }

            Console.WriteLine("*Aperte enter para sair.*");
            Console.ReadKey();

        }
    }
}
