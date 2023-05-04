using System;

namespace Biblioteca{
    public class Program{
        
        static void Main (string[] args){
            Biblioteca biblioteca = new Biblioteca();
           biblioteca.CarregarDados();

           int opcao;
           
           do{

            Console.Clear();
            Console.WriteLine(" -- Bem Vindo à Biblioteca -- ");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Consulta");
            Console.WriteLine("3 - Empréstimos");
            Console.WriteLine("4 - Devoluções");
            Console.WriteLine("0 - Sair");

            int.TryParse(Console.ReadLine(), out opcao);

            switch (opcao){
                case 1:
                    Cadastro(biblioteca);
                    break;
                case 2:
                    Consulta(biblioteca);
                    break;
                case 3:
                    Emprestimo(biblioteca);
                    break;
                case 4:
                    Devolucoes(biblioteca);
                    break;
                case 0:
                    Console.WriteLine("Encerrando O Sistema...");
                    Console.ReadKey();
                    break;
            }


           }while(opcao != 0);

        


            

        }
        static void Cadastro(Biblioteca biblioteca){

        }
        static void Consulta(Biblioteca biblioteca){}
        static void Emprestimo(Biblioteca biblioteca){}
        static void Devolucoes(Biblioteca biblioteca){}
    }


}
