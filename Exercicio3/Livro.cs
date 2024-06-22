using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Livro : ItemBiblioteca, IEmprestavel
    {
        private bool _livroDisponivel;

        public Livro()
        {
        }
        public Livro(string titulo, string autor, int anoDePublicacao) : base(titulo, autor, anoDePublicacao)
        {
            _livroDisponivel = true;
        }

        public override void Devolver()
        {
            _livroDisponivel = true;
            Console.WriteLine("O livro "+Titulo+ " foi devolvido.");

        }

        public override void Emprestar()
        {
            if (_livroDisponivel)
            {
                _livroDisponivel = false;
                Console.WriteLine("O livro foi emprestado.");
            }
            else
            {
                Console.WriteLine("livro "+Titulo+ " não está disponível.");
            }

        }


        
        public override void ExibirInformacoes()
        {
            Console.WriteLine($" Livro {Titulo} por {Autor}, publicado em {AnoDePublicacao}");
        }



        public DateTime ObterPrazoDeDevolucao()
        {
            return DateTime.Now.AddDays(7);
        }

        public bool VerificarDisponibilidade()
        {
            return _livroDisponivel;
        }
    }
}
