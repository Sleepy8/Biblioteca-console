using System;
namespace Biblioteca{
    public class Cliente : Pessoa {
        public int Id{ get; set; }
        public string Telefone { get; set;}

         public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
        }

    }
}