using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Criador_de_metas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VÁRIAVEIS
            string texto = @"C:\Users\richa\Desktop\Criador_de_metas.txt";
            string meta_escolhida = "", /*conhece_meta = "",*/ s_smart = "", m_smart = "", a_smart = "", r_smart = "", t_smart = "", g_grow = "", r_grow = "", o_grow = "", w_grow = "", w_grow1 = "", w_grow2 = "";

            // LAYOUT
            Console.WriteLine("=================================");
            Console.WriteLine("\tCRIADOR DE METAS");
            Console.WriteLine("=================================");

            //ENTRADA
            Console.WriteLine("\nQual estilo de meta que deseja criar?");
            Console.WriteLine("\t1 - Meta S.M.A.R.T");
            Console.WriteLine("\t2 - Meta G.R.O.W");
            /*Console.Write("\nVocê conhece o metodo utilizado nessas metas? Sim ou Não?: ");
            conhece_meta = Console.ReadLine();
            conhece_meta = conhece_meta.ToUpper();
            while (conhece_meta != "SIM" && conhece_meta != "S" && conhece_meta != "NÃO" || conhece_meta != "NAO" || conhece_meta == "N" || conhece_meta == "")
            {
                Console.WriteLine("Valor incorreto!");
                Console.Write("Digite apenas sim ou não!: ");
                conhece_meta = Console.ReadLine();
                conhece_meta = conhece_meta.ToUpper();
            }
            if (conhece_meta == "SIM" || conhece_meta == "S")*/
            Console.Write("Digite o número da meta desejada: ");
            meta_escolhida = Console.ReadLine();

            // CONDIÇÃO COM LOOPING
            if (meta_escolhida != "1" && meta_escolhida != "2" || meta_escolhida == "")
            {
                while (meta_escolhida != "1" && meta_escolhida != "2" || meta_escolhida == "")
                {
                    Console.WriteLine("Valor incorreto!");
                    Console.Write("Digite apenas o número descrito na tabela: ");
                    meta_escolhida = Console.ReadLine(); //entrada
                } //while
            } //if

            Console.Clear();

            //  CONDIÇÃO
            switch (meta_escolhida) //entrada
            {
                case "1":
                    // LAYOUT
                    Console.WriteLine("=================================");
                    Console.WriteLine("\tMÉTODO S.M.A.R.T"); //título
                    Console.WriteLine("=================================");

                    //ENTRADA
                    Console.Write("Digite a sua meta (específica): ");
                    s_smart = Console.ReadLine();
                    Console.Write("Digite a forma de medida, o que deseja alcançar? (mensurável): ");
                    m_smart = Console.ReadLine();
                    Console.Write("Digite se a meta está dentro da sua realidade atual, Sim ou Não? (atingível): ");
                    a_smart = Console.ReadLine();
                    a_smart = a_smart.ToUpper();

                    while (!(a_smart == "SIM" && a_smart == "S" && a_smart == "NÃO" && a_smart == "NAO" && a_smart == "N" || a_smart != ""))
                    {
                        Console.WriteLine("Valor incorreto!");
                        Console.Write("Digite apenas sim ou não!: ");
                        a_smart = Console.ReadLine();
                        a_smart = a_smart.ToUpper();
                    } //while

                    if (a_smart == "SIM" || a_smart == "S")
                    {
                        Console.Write("Digite a relevancia para o seu momento atual (relevante/realista): ");
                        r_smart = Console.ReadLine();
                        Console.Write("Digite o prazo para atingir-la (temporal): ");
                        t_smart = Console.ReadLine();
                    } //if
                    else
                    {
                        if (a_smart == "NÃO" || a_smart == "NAO" || a_smart == "N")
                        {
                            Console.WriteLine("Não é possível alcançar a meta com ela sendo impossível para sua realidade, se adeque a ela primeiramente!");
                        } //if
                    } //else

                    break;

                case "2":
                    //LAYOUT
                    Console.WriteLine("================================");
                    Console.WriteLine("\tMÉTODO G.R.O.W"); //título
                    Console.WriteLine("================================");

                    //ENTRADA
                    Console.Write("Digite a sua meta (objetivo): ");
                    g_grow = Console.ReadLine();
                    Console.Write("Digite a sua realidade atual e suas condições para realizar a meta (realidade): ");
                    r_grow = Console.ReadLine();
                    Console.Write("Digite as opções viaveis para você cumprir com o objetivo (opções): ");
                    o_grow = Console.ReadLine();
                    Console.Write("Digite o porque você quer cumprir o objetivo (vontade): ");
                    w_grow = Console.ReadLine();
                    Console.Write("Digite o como você vai cumprir o objetivo (vontade): ");
                    w_grow1 = Console.ReadLine();
                    Console.Write("Digite o quando você irá cumprir o objetivo (vontade): ");
                    w_grow2 = Console.ReadLine();

                    break;
                    
            } //switch

            //SAÍDA
            using (StreamWriter sw = File.AppendText(texto))
            {
                //LAYOUT
                sw.WriteLine("=================================");
                sw.WriteLine("\tCRIADOR DE METAS");
                sw.WriteLine("=================================");
                //SAÍDA
                sw.WriteLine("Estilos de meta: ");
                sw.WriteLine("\t1 - Meta S.M.A.R.T");
                sw.WriteLine("\t2 - Meta G.R.O.W");
                sw.WriteLine("Meta selecionada: {0}", meta_escolhida);
                if(meta_escolhida == "1")
                {
                    //SAÍDA
                    sw.WriteLine("\n=================================");
                    sw.WriteLine("\tMÉTODO S.M.A.R.T");
                    sw.WriteLine("=================================");

                    sw.Write("META: {0}", s_smart);
                    sw.Write("\nOBJETIVO A ALCANÇAR: {0}", m_smart);
                    sw.Write("\nESTÁ DENTRO DA REALIDADE ATUAL?: {0}", a_smart);
                    if (a_smart == "NÃO" || a_smart == "NAO" || a_smart == "N")
                    {
                        sw.WriteLine("\n\n* FALHA AO COMPLETAR A META, REALIZE OUTRA NOVAMENTE! *");
                        sw.WriteLine("____________________________________________");
                    } //if
                    else
                    {
                        sw.Write("\nRELEVÂNCIA DA META NO MOMENTO ATUAL: {0}", r_smart);
                        sw.Write("\nPRAZO: {0}", t_smart);
                        sw.WriteLine("\n____________________________________________");
                        sw.WriteLine("");
                    } //else
                } //if
                else
                {
                    //SAÍDA

                    if (meta_escolhida == "2")
                    {
                        sw.WriteLine("\n================================");
                        sw.WriteLine("\tMÉTODO G.R.O.W");
                        sw.WriteLine("================================");
                        sw.Write("META: {0}", g_grow);
                        sw.Write("\nREALIDADE ATUAL E CONDIÇÕES: {0}", r_grow);
                        sw.Write("\nOPÇÕES PARA CUMPRIR A META: {0}", o_grow);
                        sw.Write("\nPOR QUÊ VOCÊ QUER CUMPRIR A META: {0}", w_grow);
                        sw.Write("\nCOMO VAI CUMPRIR A META: {0}", w_grow1);
                        sw.Write("\nQUANDO VAI CUMPRIR A META: {0}", w_grow2);
                        sw.WriteLine("\n____________________________________________");
                        sw.WriteLine();
                    }
                }
            }

            Console.ReadKey();
            System.Diagnostics.Process.Start("notepad.exe", texto); 
        }
    }
}
