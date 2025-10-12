using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, string> usuarios = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--- JOGO DO CONSOLE ---");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Cadastrar");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    FazerLogin();
                    break;
                case "2":
                    FazerCadastro();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void FazerLogin()
    {
        Console.Clear();
        Console.WriteLine("--- TELA DE LOGIN ---");
        Console.Write("Usuário: ");
        string usuario = Console.ReadLine();
        Console.Write("Senha: ");
        string senha = LerSenhaSegura();

        if (usuarios.ContainsKey(usuario) && usuarios[usuario] == senha)
        {
            Console.WriteLine("\nLogin bem-sucedido! Bem-vindo(a)!");
            // Inicia o jogo aqui...
        }
        else
        {
            Console.WriteLine("\nUsuário ou senha incorretos.");
        }
        Console.ReadKey();
    }

    static void FazerCadastro()
    {
        Console.Clear();
        Console.WriteLine("--- TELA DE CADASTRO ---");
        Console.Write("Escolha um usuário: ");
        string usuario = Console.ReadLine();

        if (usuarios.ContainsKey(usuario))
        {
            Console.WriteLine("Este usuário já existe.");
        }
        else
        {
            Console.Write("Escolha uma senha: ");
            string senha = LerSenhaSegura();
            usuarios.Add(usuario, senha);
            Console.WriteLine("\nCadastro realizado com sucesso!");
        }
        Console.ReadKey();
    }

    static string LerSenhaSegura()
    {
        string senha = "";
        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Enter)
            {
                break;
            }
            else if (tecla.Key == ConsoleKey.Backspace && senha.Length > 0)
            {
                senha = senha.Remove(senha.Length - 1);
                Console.Write("\b \b");
            }
            else
            {
                senha += tecla.KeyChar;
                Console.Write("*");
            }
        }
        return senha;
    }
}