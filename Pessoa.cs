using System;
namespace Biblioteca{
    public abstract class Pessoa : IPessoa{
        public string Nome { get; set;}
        public DateTime DataNascimento { get; set; }

        public virtual void ExibirInformacoes(){
            Console.WriteLine($"Nome: {Nome}\nData de Nascimento: {DataNascimento.ToShortDateString()}");
        }
    }
}