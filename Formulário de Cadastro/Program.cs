using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Formulário_de_Cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* PROJETO: Formulário para cadastro de uma entrevista de emprego.
             * PROBLEMA: Fazer o cadastro da pessoa e salvar no sistema.
             * DATA: 25/05/2033
             * AUTOR: Richard Rotta
             */

            string criando_login = "", criando_password = "", entrada1 = "", nome = "", rg = "", cpf = "", celular = "", login_v = "", password_v = "", cadastro_incorreto = "", login = "", password = "", novo_formulario = "", p_deficiencia = "", q_deficiencia = "1", cargo_desej = "", dados_corretos = "", enviar_form = ""; //Variável
            int i = 1; //Variável

            Console.WriteLine("\t\t\t|---------------------------------------------------------|");
            Console.WriteLine("\t\t\t {0}º - Formulário de cadastramento para aquisição de vagas", i); //Título
            Console.WriteLine("\t\t\t|_________________________________________________________|");

            while (entrada1 == "") //Looping
            {
                Console.Write("\nVocê já possui um cadastro em nosso site? Sim ou Não?: ");
                entrada1 = Console.ReadLine();
                entrada1 = entrada1.ToUpper();
            } //while (entrada1)

            switch (entrada1) //Condição
            {
                case "NÃO":
                    {
                        while (criando_login == "" || criando_password == "") //Looping
                        {
                            Console.Write("Digite um nome de login: ");
                            criando_login = Console.ReadLine(); //Entrada
                            Console.Write("Digite uma senha: ");
                            criando_password = Console.ReadLine(); //Entrada
                        } //while inside case "NÃO" inside switch of (entrada1)
                        Console.WriteLine("\nGRAVANDO...");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nCadastro feito com sucesso!");
                        Thread.Sleep(1500);
                        Console.Clear();

                        Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                        Console.Write("\nDigite seu login: ");
                        login = Console.ReadLine(); //Entrada
                        Console.Write("Digite sua senha: ");
                        password = Console.ReadLine(); //Entrada
                        Console.WriteLine("\nVERIFICANDO...");
                        Thread.Sleep(1500);
                        Console.Clear();

                        if (login == criando_login && password == criando_password) //Condição
                        {
                            while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s" || novo_formulario == "") //Looping
                            {
                                while (dados_corretos == "NÃO" || dados_corretos == "N" || dados_corretos == "") //Looping
                                {
                                    Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                    while (nome == "") //Looping
                                    {
                                        Console.Write("\nDigite seu nome: ");
                                        nome = Console.ReadLine(); //Entrada
                                    } //while (nome) inside if inside case "NÃO" inside switch of (entrada1)

                                    while (rg == "") //Looping
                                    {
                                        Console.Write("Digite seu RG: ");
                                        rg = Console.ReadLine(); //Entrada
                                    } //while (rg) inside if inside case "NÃO" inside switch of (entrada1)

                                    while (cpf == "") //Looping
                                    {
                                        Console.Write("Digite seu CPF: ");
                                        cpf = Console.ReadLine(); //Entrada
                                    } //while (cpf) inside if inside case "NÃO" inside switch of (entrada1)

                                    while (celular == "") //Looping
                                    {
                                        Console.Write("Digite seu número de celular: ");
                                        celular = Console.ReadLine(); //Entrada
                                    } //while (celular) inside if inside case "NÃO" inside switch of (entrada1)

                                    while (p_deficiencia == "") //Looping
                                    {
                                        Console.Write("Possui algum tipo de deficiência?: ");
                                        p_deficiencia = Console.ReadLine();//Entrada
                                        p_deficiencia = p_deficiencia.ToUpper();
                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                        {
                                            Console.Write("Qual?: ");
                                            q_deficiencia = Console.ReadLine(); //Entrada
                                        }

                                    } //while (p_deficiencia) inside if inside case "NÃO" inside switch of (entrada1)

                                    while (cargo_desej == "") //Looping
                                    {
                                        Console.Write("Cargo desejado: ");
                                        cargo_desej = Console.ReadLine(); //Entrada
                                    } //while (cargo_desej) inside if inside case "NÃO" inside switch of (entrada1)

                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(5000);

                                    Console.WriteLine("\n======================================");
                                    Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Nome: {0}", nome); //Saída
                                    Console.WriteLine("RG: {0}", rg); //Saída
                                    Console.WriteLine("CPF: {0}", cpf); //Saída
                                    Console.WriteLine("Número de celular: {0}", celular); //Saída
                                    Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                    if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                    {
                                        Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                    } // if inside if inside case "NÃO" inside switch of (entrada1)
                                    Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                    Console.WriteLine("--------------------------------------");

                                    while (enviar_form == "")
                                    {
                                        Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                        enviar_form = Console.ReadLine(); //Entrada
                                        enviar_form = enviar_form.ToUpper();
                                    }

                                    if(enviar_form == "SIM" || enviar_form == "S")
                                    {
                                        Console.WriteLine("\nENVIANDO...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                        Thread.Sleep(1500);
                                    } //if (enviar_form) inside if (login/password) inside case "NÃO" inside switch of (entrada1)
                                    
                                    /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                    dados_corretos = Console.ReadLine(); //Entrada
                                    dados_corretos = dados_corretos.ToUpper();*/

                                } //while

                                /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                novo_formulario = Console.ReadLine(); //Entrada
                                novo_formulario = novo_formulario.ToUpper();

                                if (novo_formulario == "SIM" || novo_formulario == "S")
                                {
                                    Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                    Thread.Sleep(3000);
                                }*/

                                //i = i++; //Incremento
                            } //while

                        } //if inside case "NÃO" inside switch of (entrada1)
                        else
                        {
                            Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                        } //else inside case "NÃO" inside switch of (entrada1)

                    } //case "NÃO" inside switch of (entrada1)
                    break;

                case "NAO":
                    {

                        while (criando_login == "" || criando_password == "") //Looping
                        {
                            Console.Write("Digite um nome de login: ");
                            criando_login = Console.ReadLine(); //Entrada
                            Console.Write("Digite uma senha: ");
                            criando_password = Console.ReadLine(); //Entrada
                        } //while inside case "NAO" inside switch of (entrada1)
                        Console.WriteLine("\nGRAVANDO...");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nCadastro feito com sucesso!");
                        Thread.Sleep(1500);
                        Console.Clear();

                        Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                        Console.Write("\nDigite seu login: ");
                        login = Console.ReadLine(); //Entrada
                        Console.Write("Digite sua senha: ");
                        password = Console.ReadLine(); //Entrada
                        Console.WriteLine("\nVERIFICANDO...");
                        Thread.Sleep(1500);
                        Console.Clear();

                        if (login == criando_login && password == criando_password) //Condição
                        {
                            //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                            {
                                //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                {
                                    Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                    while (nome == "") //Looping
                                    {
                                        Console.Write("\nDigite seu nome: ");
                                        nome = Console.ReadLine(); //Entrada
                                    } //while (nome) inside if inside case "NAO" inside switch of (entrada1)

                                    while (rg == "") //Looping
                                    {
                                        Console.Write("Digite seu RG: ");
                                        rg = Console.ReadLine(); //Entrada
                                    } //while (rg) inside if inside case "NAO" inside switch of (entrada1)

                                    while (cpf == "") //Looping
                                    {
                                        Console.Write("Digite seu CPF: ");
                                        cpf = Console.ReadLine(); //Entrada
                                    } //while (cpf) inside if inside case "NAO" inside switch of (entrada1)

                                    while (celular == "") //Looping
                                    {
                                        Console.Write("Digite seu número de celular: ");
                                        celular = Console.ReadLine(); //Entrada
                                    } //while (celular) inside if inside case "NAO" inside switch of (entrada1)

                                    while (p_deficiencia == "") //Looping
                                    {
                                        Console.Write("Possui algum tipo de deficiência?: ");
                                        p_deficiencia = Console.ReadLine();//Entrada
                                        p_deficiencia = p_deficiencia.ToUpper();

                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                        {
                                            Console.Write("Qual?: ");
                                            q_deficiencia = Console.ReadLine(); //Entrada
                                        }

                                    } //while (p_deficiencia) inside if inside case "NAO" inside switch of (entrada1)

                                    while (cargo_desej == "") //Looping
                                    {
                                        Console.Write("Cargo desejado: ");
                                        cargo_desej = Console.ReadLine(); //Entrada
                                    } //while (cargo_desej) inside if inside case "NAO" inside switch of (entrada1)

                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(5000);

                                    Console.WriteLine("\n======================================");
                                    Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Nome: {0}", nome); //Saída
                                    Console.WriteLine("RG: {0}", rg); //Saída
                                    Console.WriteLine("CPF: {0}", cpf); //Saída
                                    Console.WriteLine("Número de celular: {0}", celular); //Saída
                                    Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                    if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                    {
                                        Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                    } // if inside if inside case "NAO" inside switch of (entrada1)
                                    Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                    Console.WriteLine("--------------------------------------");

                                    while (enviar_form == "")
                                    {
                                        Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                        enviar_form = Console.ReadLine(); //Entrada
                                        enviar_form = enviar_form.ToUpper();
                                    }

                                    if (enviar_form == "SIM" || enviar_form == "S")
                                    {
                                        Console.WriteLine("\nENVIANDO...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                        Thread.Sleep(1500);
                                    } //if (enviar_form) inside if (login/password) inside case "NAO" inside switch of (entrada1)

                                    /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                    dados_corretos = Console.ReadLine(); //Entrada
                                    dados_corretos = dados_corretos.ToUpper();*/

                                } //while

                                /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                novo_formulario = Console.ReadLine(); //Entrada
                                novo_formulario = novo_formulario.ToUpper();*/

                                /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                {
                                    Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                    Thread.Sleep(3000);
                                }*/

                                //i = i++; //Incremento
                            } //while

                        } //if inside case "NAO" inside switch of (entrada1)
                        else
                        {
                            Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                        } //else inside case "NAO" inside switch of (entrada1)

                    } //case "NAO" inside switch of (entrada1)
                    break;

                case "N":
                    {

                        while (criando_login == "" || criando_password == "") //Looping
                        {
                            Console.Write("Digite um nome de login: ");
                            criando_login = Console.ReadLine(); //Entrada
                            Console.Write("Digite uma senha: ");
                            criando_password = Console.ReadLine(); //Entrada
                        } //while inside case "N" inside switch of (entrada1)
                        Console.WriteLine("\nGRAVANDO...");
                        Thread.Sleep(2000);
                        Console.WriteLine("\nCadastro feito com sucesso!");
                        Thread.Sleep(1500);
                        Console.Clear();

                        Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                        Console.Write("\nDigite seu login: ");
                        login = Console.ReadLine(); //Entrada
                        Console.Write("Digite sua senha: ");
                        password = Console.ReadLine(); //Entrada
                        Console.WriteLine("\nVERIFICANDO...");
                        Thread.Sleep(1500);
                        Console.Clear();

                        if (login == criando_login && password == criando_password) //Condição
                        {
                            //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                            {
                                //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                {
                                    Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                    while (nome == "") //Looping
                                    {
                                        Console.Write("\nDigite seu nome: ");
                                        nome = Console.ReadLine(); //Entrada
                                    } //while (nome) inside if inside case "N" inside switch of (entrada1)

                                    while (rg == "") //Looping
                                    {
                                        Console.Write("Digite seu RG: ");
                                        rg = Console.ReadLine(); //Entrada
                                    } //while (rg) inside if inside case "N" inside switch of (entrada1)

                                    while (cpf == "") //Looping
                                    {
                                        Console.Write("Digite seu CPF: ");
                                        cpf = Console.ReadLine(); //Entrada
                                    } //while (cpf) inside if inside case "N" inside switch of (entrada1)

                                    while (celular == "") //Looping
                                    {
                                        Console.Write("Digite seu número de celular: ");
                                        celular = Console.ReadLine(); //Entrada
                                    } //while (celular) inside if inside case "N" inside switch of (entrada1)

                                    while (p_deficiencia == "") //Looping
                                    {
                                        Console.Write("Possui algum tipo de deficiência?: ");
                                        p_deficiencia = Console.ReadLine();//Entrada
                                        p_deficiencia = p_deficiencia.ToUpper();

                                            if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                            {
                                                Console.Write("Qual?: ");
                                                q_deficiencia = Console.ReadLine(); //Entrada
                                            }

                                    } //while (p_deficiencia) inside if inside case "N" inside switch of (entrada1)

                                    while (cargo_desej == "") //Looping
                                    {
                                        Console.Write("Cargo desejado: ");
                                        cargo_desej = Console.ReadLine(); //Entrada
                                    } //while (cargo_desej) inside if inside case "N" inside switch of (entrada1)

                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(5000);

                                    Console.WriteLine("\n======================================");
                                    Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                    Console.WriteLine("======================================");
                                    Console.WriteLine("Nome: {0}", nome); //Saída
                                    Console.WriteLine("RG: {0}", rg); //Saída
                                    Console.WriteLine("CPF: {0}", cpf); //Saída
                                    Console.WriteLine("Número de celular: {0}", celular); //Saída
                                    Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                    if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                    {
                                        Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                    } // if inside if inside case "N" inside switch of (entrada1)
                                    Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                    Console.WriteLine("--------------------------------------");

                                    while (enviar_form == "")
                                    {
                                        Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                        enviar_form = Console.ReadLine(); //Entrada
                                        enviar_form = enviar_form.ToUpper();
                                    }

                                    if (enviar_form == "SIM" || enviar_form == "S")
                                    {
                                        Console.WriteLine("\nENVIANDO...");
                                        Thread.Sleep(2000);
                                        Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                        Thread.Sleep(1500);
                                    } //if (enviar_form) inside if (login/password) inside case "N" inside switch of (entrada1)

                                    /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                    dados_corretos = Console.ReadLine(); //Entrada
                                    dados_corretos = dados_corretos.ToUpper();*/

                                } //while

                                /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                novo_formulario = Console.ReadLine(); //Entrada
                                novo_formulario = novo_formulario.ToUpper();*/

                                /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                {
                                    Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                    Thread.Sleep(3000);
                                }*/

                                //i = i++; //Incremento
                            } //while

                        } //if inside case "N" inside switch of (entrada1)
                        else
                        {
                            Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                        } //else inside case "N" inside switch of (entrada1)

                    } //case "N" inside switch of (entrada1)
                    break;

                case "SIM":
                    {
                        while (login_v == "" || password_v == "") //Looping
                        {
                            Console.Write("Digite seu login: ");
                            login_v = Console.ReadLine(); //Entrada
                            Console.Write("Digite sua senha: ");
                            password_v = Console.ReadLine(); //Entrada
                        } //while (login_v/password_v) inside case "SIM" inside switch of (entrada1)
                        Console.WriteLine("\nPROCESSANDO...");
                        Thread.Sleep(1000);

                        if (login_v != criando_login && password_v != criando_password) //Condição
                        {
                            Console.Write("\nNão encontramos seu cadastro em nosso sistema!");
                            Console.Write("\nDeseja fazer um cadastro? Sim ou Não?: ");
                            cadastro_incorreto = Console.ReadLine();
                            cadastro_incorreto = cadastro_incorreto.ToUpper();
                        } //if inside case "SIM" inside switch of (entrada1)

                        switch (cadastro_incorreto) //Condição
                        {
                            case "SIM":
                                {
                                    while (criando_login == "" || criando_password == "") //Looping
                                    {
                                        Console.Write("\nDigite um nome de login: ");
                                        criando_login = Console.ReadLine(); //Entrada
                                        Console.Write("Digite uma senha: ");
                                        criando_password = Console.ReadLine(); //Entrada
                                    } //while (criando_login/criando_password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nCadastro feito com sucesso!");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                                    Console.Write("\nDigite seu login: ");
                                    login = Console.ReadLine(); //Entrada
                                    Console.Write("Digite sua senha: ");
                                    password = Console.ReadLine(); //Entrada
                                    Console.WriteLine("\nVERIFICANDO...");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    if (login == criando_login && password == criando_password) //Condição
                                    {
                                        //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                                        {
                                            //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                            {
                                                Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                                while (nome == "") //Looping
                                                {
                                                    Console.Write("\nDigite seu nome: ");
                                                    nome = Console.ReadLine(); //Entrada
                                                } //while (nome) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (rg == "") //Looping
                                                {
                                                    Console.Write("Digite seu RG: ");
                                                    rg = Console.ReadLine(); //Entrada
                                                } //while (rg) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (cpf == "") //Looping
                                                {
                                                    Console.Write("Digite seu CPF: ");
                                                    cpf = Console.ReadLine(); //Entrada
                                                } //while (cpf) inside if (login/password) inside inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (celular == "") //Looping
                                                {
                                                    Console.Write("Digite seu número de celular: ");
                                                    celular = Console.ReadLine(); //Entrada
                                                } //while (celular) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (p_deficiencia == "") //Looping
                                                {
                                                    Console.Write("Possui algum tipo de deficiência?: ");
                                                    p_deficiencia = Console.ReadLine();//Entrada
                                                    p_deficiencia = p_deficiencia.ToUpper();

                                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                                        {
                                                            Console.Write("Qual?: ");
                                                            q_deficiencia = Console.ReadLine(); //Entrada
                                                        } //if (p_deficiencia) inside while (q_deficiencia) inside while (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                } //while (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (cargo_desej == "") //Looping
                                                {
                                                    Console.Write("Cargo desejado: ");
                                                    cargo_desej = Console.ReadLine(); //Entrada
                                                } //while (cargo_desej) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                Console.WriteLine("\nGRAVANDO...");
                                                Thread.Sleep(5000);

                                                Console.WriteLine("\n======================================");
                                                Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                                Console.WriteLine("======================================");
                                                Console.WriteLine("Nome: {0}", nome); //Saída
                                                Console.WriteLine("RG: {0}", rg); //Saída
                                                Console.WriteLine("CPF: {0}", cpf); //Saída
                                                Console.WriteLine("Número de celular: {0}", celular); //Saída
                                                Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                                if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                                {
                                                    Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                                } // if (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                                Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                                Console.WriteLine("--------------------------------------");

                                                while (enviar_form == "")
                                                {
                                                    Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                                    enviar_form = Console.ReadLine(); //Entrada
                                                    enviar_form = enviar_form.ToUpper();
                                                }

                                                if (enviar_form == "SIM" || enviar_form == "S")
                                                {
                                                    Console.WriteLine("\nENVIANDO...");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                                    Thread.Sleep(1500);
                                                } //if (enviar_form) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                                dados_corretos = Console.ReadLine(); //Entrada
                                                dados_corretos = dados_corretos.ToUpper();*/

                                            } //while

                                            /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                            novo_formulario = Console.ReadLine(); //Entrada
                                            novo_formulario = novo_formulario.ToUpper();*/

                                            /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                            {
                                                Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                                Thread.Sleep(3000);
                                            }*/

                                            //i = i++; //Incremento
                                        } //while

                                    } //if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                    else
                                    {
                                        Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                                    } //else inside case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                }
                                break; //case "SIM" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                            case "S":
                                {
                                    while (criando_login == "" || criando_password == "") //Looping
                                    {
                                        Console.Write("\nDigite um nome de login: ");
                                        criando_login = Console.ReadLine(); //Entrada
                                        Console.Write("Digite uma senha: ");
                                        criando_password = Console.ReadLine(); //Entrada
                                    } //while (criando_login/criando_password) inside case "S" inside switch (cadastro_incorreto) inside switch of (entrada1)
                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nCadastro feito com sucesso!");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                                    Console.Write("\nDigite seu login: ");
                                    login = Console.ReadLine(); //Entrada
                                    Console.Write("Digite sua senha: ");
                                    password = Console.ReadLine(); //Entrada
                                    Console.WriteLine("\nVERIFICANDO...");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    if (login == criando_login && password == criando_password) //Condição
                                    {
                                        //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                                        {
                                            //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                            {
                                                Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                                while (nome == "") //Looping
                                                {
                                                    Console.Write("\nDigite seu nome: ");
                                                    nome = Console.ReadLine(); //Entrada
                                                } //while (nome) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (rg == "") //Looping
                                                {
                                                    Console.Write("Digite seu RG: ");
                                                    rg = Console.ReadLine(); //Entrada
                                                } //while (rg) inside inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (cpf == "") //Looping
                                                {
                                                    Console.Write("Digite seu CPF: ");
                                                    cpf = Console.ReadLine(); //Entrada
                                                } //while (cpf) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (celular == "") //Looping
                                                {
                                                    Console.Write("Digite seu número de celular: ");
                                                    celular = Console.ReadLine(); //Entrada
                                                } //while (celular) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (p_deficiencia == "") //Looping
                                                {
                                                    Console.Write("Possui algum tipo de deficiência?: ");
                                                    p_deficiencia = Console.ReadLine();//Entrada
                                                    p_deficiencia = p_deficiencia.ToUpper();

                                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                                        {
                                                            Console.Write("Qual?: ");
                                                            q_deficiencia = Console.ReadLine(); //Entrada
                                                        }

                                                } //while (p_deficiencia) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                while (cargo_desej == "") //Looping
                                                {
                                                    Console.Write("Cargo desejado: ");
                                                    cargo_desej = Console.ReadLine(); //Entrada
                                                } //while (cargo_desej) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                Console.WriteLine("\nGRAVANDO...");
                                                Thread.Sleep(5000);

                                                Console.WriteLine("\n======================================");
                                                Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                                Console.WriteLine("======================================");
                                                Console.WriteLine("Nome: {0}", nome); //Saída
                                                Console.WriteLine("RG: {0}", rg); //Saída
                                                Console.WriteLine("CPF: {0}", cpf); //Saída
                                                Console.WriteLine("Número de celular: {0}", celular); //Saída
                                                Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                                if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                                {
                                                    Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                                } // if (p_deficiencia) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                                Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                                Console.WriteLine("--------------------------------------");

                                                while (enviar_form == "")
                                                {
                                                    Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                                    enviar_form = Console.ReadLine(); //Entrada
                                                    enviar_form = enviar_form.ToUpper();
                                                }

                                                if (enviar_form == "SIM" || enviar_form == "S")
                                                {
                                                    Console.WriteLine("\nENVIANDO...");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                                    Thread.Sleep(1500);
                                                } //if (enviar_form) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                                /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                                dados_corretos = Console.ReadLine(); //Entrada
                                                dados_corretos = dados_corretos.ToUpper();*/

                                            } //while

                                            /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                            novo_formulario = Console.ReadLine(); //Entrada
                                            novo_formulario = novo_formulario.ToUpper();*/

                                            /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                            {
                                                Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                                Thread.Sleep(3000);
                                            }*/

                                            //i = i++; //Incremento
                                        } //while

                                    } //if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                    else
                                    {
                                        Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                                    } //else inside case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                                } //case "S" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                break;

                            case "NÃO":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                break;

                            case "NAO":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                break;

                            case "N":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)
                                break;

                        } //switch (cadastro_incorreto) inside case "SIM" inside switch of (entrada1)

                    } //case "SIM" inside switch of (entrada1)
                    break;

                case "S":
                    {
                        while (login_v == "" || password_v == "") //Looping
                        {
                            Console.Write("Digite seu login: ");
                            login_v = Console.ReadLine(); //Entrada
                            Console.Write("Digite sua senha: ");
                            password_v = Console.ReadLine(); //Entrada
                        } //while (login_v/password_v) inside case "S" inside switch of (entrada1)
                        Console.WriteLine("\nPROCESSANDO...");
                        Thread.Sleep(1000);

                        if (login_v != criando_login && password_v != criando_password) //Condição
                        {
                            Console.Write("\nNão encontramos seu cadastro em nosso sistema!");
                            Console.Write("\nDeseja fazer um cadastro? Sim ou Não?: ");
                            cadastro_incorreto = Console.ReadLine();
                            cadastro_incorreto = cadastro_incorreto.ToUpper();
                        } //if (login_v/login_v) inside case "S" inside switch of (entrada1)

                        switch (cadastro_incorreto) //Condição
                        {
                            case "SIM":
                                {
                                    while (criando_login == "" || criando_password == "") //Looping
                                    {
                                        Console.Write("\nDigite um nome de login: ");
                                        criando_login = Console.ReadLine(); //Entrada
                                        Console.Write("Digite uma senha: ");
                                        criando_password = Console.ReadLine(); //Entrada
                                    } //while (criando_login/crinado_password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nCadastro feito com sucesso!");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                                    Console.Write("\nDigite seu login: ");
                                    login = Console.ReadLine(); //Entrada
                                    Console.Write("Digite sua senha: ");
                                    password = Console.ReadLine(); //Entrada
                                    Console.WriteLine("\nVERIFICANDO...");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    if (login == criando_login && password == criando_password) //Condição
                                    {
                                        //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                                        {
                                            //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                            {
                                                Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                                while (nome == "") //Looping
                                                {
                                                    Console.Write("\nDigite seu nome: ");
                                                    nome = Console.ReadLine(); //Entrada
                                                } //while (nome) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (rg == "") //Looping
                                                {
                                                    Console.Write("Digite seu RG: ");
                                                    rg = Console.ReadLine(); //Entrada
                                                } //while (rg) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (cpf == "") //Looping
                                                {
                                                    Console.Write("Digite seu CPF: ");
                                                    cpf = Console.ReadLine(); //Entrada
                                                } //while (cpf) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (celular == "") //Looping
                                                {
                                                    Console.Write("Digite seu número de celular: ");
                                                    celular = Console.ReadLine(); //Entrada
                                                } //while (celular) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (p_deficiencia == "") //Looping
                                                {
                                                    Console.Write("Possui algum tipo de deficiência?: ");
                                                    p_deficiencia = Console.ReadLine();//Entrada
                                                    p_deficiencia = p_deficiencia.ToUpper();

                                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                                        {
                                                            Console.Write("Qual?: ");
                                                            q_deficiencia = Console.ReadLine(); //Entrada
                                                        } //if (p_deficiencia) inside while (q_deficiencia) while (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                } //while (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (cargo_desej == "") //Looping
                                                {
                                                    Console.Write("Cargo desejado: ");
                                                    cargo_desej = Console.ReadLine(); //Entrada
                                                } //while (cargo_desej) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                Console.WriteLine("\nGRAVANDO...");
                                                Thread.Sleep(5000);

                                                Console.WriteLine("\n======================================");
                                                Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                                Console.WriteLine("======================================");
                                                Console.WriteLine("Nome: {0}", nome); //Saída
                                                Console.WriteLine("RG: {0}", rg); //Saída
                                                Console.WriteLine("CPF: {0}", cpf); //Saída
                                                Console.WriteLine("Número de celular: {0}", celular); //Saída
                                                Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                                if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                                {
                                                    Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                                } // if (p_deficiencia) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                                Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                                Console.WriteLine("--------------------------------------");

                                                while (enviar_form == "")
                                                {
                                                    Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                                    enviar_form = Console.ReadLine(); //Entrada
                                                    enviar_form = enviar_form.ToUpper();
                                                }

                                                if (enviar_form == "SIM" || enviar_form == "S")
                                                {
                                                    Console.WriteLine("\nENVIANDO...");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                                    Thread.Sleep(1500);
                                                } //if (enviar_form) inside if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                                dados_corretos = Console.ReadLine(); //Entrada
                                                dados_corretos = dados_corretos.ToUpper();*/

                                            } //while

                                            /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                            novo_formulario = Console.ReadLine(); //Entrada
                                            novo_formulario = novo_formulario.ToUpper();*/

                                            /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                            {
                                                Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                                Thread.Sleep(3000);
                                            }*/

                                            //i = i++; //Incremento
                                        } //while

                                    } //if (login/password) inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                    else
                                    {
                                        Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                                    } //else inside case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                } //case "SIM" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                break;

                            case "S":
                                {
                                    while (criando_login == "" || criando_password == "") //Looping
                                    {
                                        Console.Write("\nDigite um nome de login: ");
                                        criando_login = Console.ReadLine(); //Entrada
                                        Console.Write("Digite uma senha: ");
                                        criando_password = Console.ReadLine(); //Entrada
                                    } //while (criando_login/criando_password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                    Console.WriteLine("\nGRAVANDO...");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("\nCadastro feito com sucesso!");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    Console.WriteLine("\n* Para acessar o formulário, faça seu login! *");

                                    Console.Write("\nDigite seu login: ");
                                    login = Console.ReadLine(); //Entrada
                                    Console.Write("Digite sua senha: ");
                                    password = Console.ReadLine(); //Entrada
                                    Console.WriteLine("\nVERIFICANDO...");
                                    Thread.Sleep(1500);
                                    Console.Clear();

                                    if (login == criando_login && password == criando_password) //Condição
                                    {
                                        //while (novo_formulario == "Sim" || novo_formulario == "sim" || novo_formulario == "S" || novo_formulario == "s") //Looping
                                        {
                                            //while (dados_corretos == "NÃO" || dados_corretos == "N") //Looping
                                            {
                                                Console.WriteLine("\n{0} - * FORMULÁRIO DE INSCRIÇÃO *", i); //Título

                                                while (nome == "") //Looping
                                                {
                                                    Console.Write("\nDigite seu nome: ");
                                                    nome = Console.ReadLine(); //Entrada
                                                } //while (nome) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (rg == "") //Looping
                                                {
                                                    Console.Write("Digite seu RG: ");
                                                    rg = Console.ReadLine(); //Entrada
                                                } //while (rg) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (cpf == "") //Looping
                                                {
                                                    Console.Write("Digite seu CPF: ");
                                                    cpf = Console.ReadLine(); //Entrada
                                                } //while (cpf) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (celular == "") //Looping
                                                {
                                                    Console.Write("Digite seu número de celular: ");
                                                    celular = Console.ReadLine(); //Entrada
                                                } //while (celular) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (p_deficiencia == "") //Looping
                                                {
                                                    Console.Write("Possui algum tipo de deficiência?: ");
                                                    p_deficiencia = Console.ReadLine();//Entrada
                                                    p_deficiencia = p_deficiencia.ToUpper();

                                                        if (p_deficiencia == "SIM" || p_deficiencia == "S")
                                                        {
                                                            Console.Write("Qual?: ");
                                                            q_deficiencia = Console.ReadLine(); //Entrada
                                                        } //if (p_deficiencia) inside while (q_deficiencia) inside /while (p_deficiencia) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                } //while (p_deficiencia) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                while (cargo_desej == "") //Looping
                                                {
                                                    Console.Write("Cargo desejado: ");
                                                    cargo_desej = Console.ReadLine(); //Entrada
                                                } //while (cargo_desej) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                Console.WriteLine("\nGRAVANDO...");
                                                Thread.Sleep(5000);

                                                Console.WriteLine("\n======================================");
                                                Console.WriteLine("\t  DADOS DO USUÁRIO:");
                                                Console.WriteLine("======================================");
                                                Console.WriteLine("Nome: {0}", nome); //Saída
                                                Console.WriteLine("RG: {0}", rg); //Saída
                                                Console.WriteLine("CPF: {0}", cpf); //Saída
                                                Console.WriteLine("Número de celular: {0}", celular); //Saída
                                                Console.WriteLine("Possui algum tipo de deficiência?: {0}", p_deficiencia); //Saída
                                                if (p_deficiencia == "SIM" || p_deficiencia == "S") //Condição
                                                {
                                                    Console.WriteLine("Qual?: {0}", q_deficiencia); //Saída
                                                } // if (p_deficiencia) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                                Console.WriteLine("Cargo desejado: {0}", cargo_desej); //Saída
                                                Console.WriteLine("--------------------------------------");

                                                while (enviar_form == "")
                                                {
                                                    Console.Write("\nDeseja enviar seu formulário? Sim ou Não?: ");
                                                    enviar_form = Console.ReadLine(); //Entrada
                                                    enviar_form = enviar_form.ToUpper();
                                                }

                                                if (enviar_form == "SIM" || enviar_form == "S")
                                                {
                                                    Console.WriteLine("\nENVIANDO...");
                                                    Thread.Sleep(2000);
                                                    Console.WriteLine("\nSeu formulário foi enviado, boa sorte!");
                                                    Thread.Sleep(1500);
                                                } //if (enviar_form) inside if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                                /*Console.Write("\nSeus dados estão corretos? Sim ou Não?: ");
                                                dados_corretos = Console.ReadLine(); //Entrada
                                                dados_corretos = dados_corretos.ToUpper();*/

                                            } //while

                                            /*Console.Write("\nDeseja fazer um novo formulário? Sim ou Não: ");
                                            novo_formulario = Console.ReadLine(); //Entrada
                                            novo_formulario = novo_formulario.ToUpper();*/

                                            /*if (novo_formulario == "SIM" || novo_formulario == "S")
                                            {
                                                Console.WriteLine("\nCARREGANDO NOVO FORMULÁRIO...");
                                                Thread.Sleep(3000);
                                            }*/

                                            //i = i++; //Incremento
                                        } //while

                                    } //if (login/password) inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                    else
                                    {
                                        Console.WriteLine("\nInfelizmente seus dados estão incorretos, tente novamente!");
                                    } //else inside case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                                } //case "S" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                break;

                            case "NÃO":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                break;

                            case "NAO":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                break;

                            case "N":
                                {
                                    Console.WriteLine("\n* Lamento, mas infelizmente não será possível você realizar nosso formulário, peço que se cadastre em nosso sistema primeiramente! *");
                                } //case "NÃO" inside switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)
                                break;

                        } //switch (cadastro_incorreto) inside case "S" inside switch of (entrada1)

                    } // case "S" inside switch of (entrada1)
                    break;

            } //switch (entrada1)

            Console.WriteLine("\nPara sair, clique em qualquer tecla!");
            Console.ReadKey();

        }
    }
}
