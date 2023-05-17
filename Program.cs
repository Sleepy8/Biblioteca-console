using System;
using System.Collections.Generic;

namespace Biblioteca
{
	class Program
	{
		static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            biblioteca.CarregarDados();

            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Bem-vindo à Biblioteca");
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Cadastro");
                Console.WriteLine("2 - Consultas");
                Console.WriteLine("3 - Empréstimos");
                Console.WriteLine("4 - Devoluções");
                Console.WriteLine("0 - Sair");

                int.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case 1:
                        Cadastro(biblioteca);
                        break;
                    case 2:
                        Consultas(biblioteca);
                        break;
                    case 3:
                        Emprestimos(biblioteca);
                        break;
                    case 4:
                        Devolucoes(biblioteca);
                        break;
                    case 0:
                        Console.WriteLine("Encerrando o sistema...");
                        biblioteca.SalvarDados();
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != 0);
        }
				
		static void Cadastro(Biblioteca biblioteca)
		{
			Console.Clear();
			Console.WriteLine("Selecione uma opção de cadastro:");
			Console.WriteLine("1 - Cadastrar cliente");
			Console.WriteLine("2 - Cadastrar livro");
			Console.WriteLine("0 - Voltar");

			int.TryParse(Console.ReadLine(), out int opcao);

			switch (opcao)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Cadastro de Cliente:");
					Console.Write("Nome: ");
					string nomeCliente = Console.ReadLine();
					Console.Write("Data de nascimento (AAAA-MM-DD): ");
					DateTime.TryParse(Console.ReadLine(), out DateTime dataNascimento);
					Console.Write("Telefone: ");
					string telefone = Console.ReadLine();

					Cliente novoCliente = new Cliente { Id = biblioteca.clientes.Count + 1, Nome = nomeCliente, DataNascimento = dataNascimento, Telefone = telefone };
					biblioteca.clientes.Add(novoCliente);

					Console.WriteLine("Cliente cadastrado com sucesso!");
					Console.ReadKey();
					break;

				case 2:
					Console.Clear();
					Console.WriteLine("Cadastro de Livro:");
					Console.Write("Título: ");
					string titulo = Console.ReadLine();
					Console.Write("Autor: ");
					string autor = Console.ReadLine();

					Livro novoLivro = new Livro { Id = biblioteca.livros.Count + 1, Titulo = titulo, Autor = autor, Disponivel = true };
					biblioteca.livros.Add(novoLivro);

					Console.WriteLine("Livro cadastrado com sucesso!");
					Console.ReadKey();
					break;

				case 0:
					// Retorna ao menu principal
					break;

				default:
					Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;
			}
		}
				
		static void Consultas(Biblioteca biblioteca)
		{
			Console.Clear();
			Console.WriteLine("Selecione uma opção de consulta:");
			Console.WriteLine("1 - Listar clientes");
			Console.WriteLine("2 - Listar livros");
			Console.WriteLine("0 - Voltar");

			int.TryParse(Console.ReadLine(), out int opcao);

			switch (opcao)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Lista de Clientes:");

					foreach (Cliente cliente in biblioteca.clientes)
					{
						Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}, Data de Nascimento: {cliente.DataNascimento:yyyy-MM-dd}, Telefone: {cliente.Telefone}");
					}

					Console.WriteLine("\nPressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;

				case 2:
					Console.Clear();
					Console.WriteLine("Lista de Livros:");

					foreach (Livro livro in biblioteca.livros)
					{
						Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor}, Disponível: {livro.Disponivel}");
					}

					Console.WriteLine("\nPressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;

				case 0:
					// Retorna ao menu principal
					break;

				default:
					Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;
			}
		}
		
		static void Emprestimos(Biblioteca biblioteca)
		{
			Console.Clear();
			Console.WriteLine("Selecione uma opção de empréstimo:");
			Console.WriteLine("1 - Emprestar livro");
			Console.WriteLine("2 - Devolver livro");
			Console.WriteLine("0 - Voltar");

			int.TryParse(Console.ReadLine(), out int opcao);

			switch (opcao)
			{
				case 1:
					Console.Clear();
					Console.WriteLine("Empréstimo de Livro:");
					Console.Write("ID do cliente: ");
					int.TryParse(Console.ReadLine(), out int idCliente);
					Console.Write("ID do livro: ");
					int.TryParse(Console.ReadLine(), out int idLivro);

					biblioteca.EmprestarLivro(idCliente, idLivro);

					Console.WriteLine("Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;

				case 2:
					Console.Clear();
					Console.WriteLine("Devolução de Livro:");
					Console.Write("ID do cliente: ");
					int.TryParse(Console.ReadLine(), out int idClienteDev);
					Console.Write("ID do livro: ");
					int.TryParse(Console.ReadLine(), out int idLivroDev);

					biblioteca.DevolverLivro(idClienteDev, idLivroDev);

					Console.WriteLine("Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;

				case 0:
					// Retorna ao menu principal
					break;

				default:
					Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
					Console.ReadKey();
					break;
			}
		}
		
		static void Devolucoes(Biblioteca biblioteca)
        {
            Console.Clear();
            Console.WriteLine("Devolução de Livro:");
            Console.Write("ID do cliente: ");
            int.TryParse(Console.ReadLine(), out int idCliente);
            Console.Write("ID do livro: ");
            int.TryParse(Console.ReadLine(), out int idLivro);

            biblioteca.DevolverLivro(idCliente, idLivro);

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }				
	}
}
