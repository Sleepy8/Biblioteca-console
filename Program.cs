using System;

namespace Biblioteca{
    public class Program{
        
        static void Main (string[] args){
            Biblioteca biblioteca = new Biblioteca();
            //adicionando clientes
            biblioteca.clientes.Add(new Cliente {Id = 1, Nome = "Jaspion",  
            DataNascimento = new DateTime(1971, 01, 10), Telefone = "4123213213"});
            biblioteca.clientes.Add(new Cliente {Id = 2, Nome = "sototos", 
            DataNascimento = new DateTime(1954, 10, 30), Telefone = "423123213213"});

            //add livros
            biblioteca.livros.Add(new Livro {Id = 1001, Titulo = "Maria das cores", 
            Autor = "Gonzales Ermano", Disponivel = true});

            

            biblioteca.livros.Add(new Livro {Id = 1002, Titulo = "O cortiço",
            Autor = "Azevedo", Disponivel = true});
            //emprestando o livro

            biblioteca.EmprestarLivro(1, 1002);


            //devolvendo livro

            biblioteca.DevolverLivro(5, 1004);


        


            

        }
    }


}
