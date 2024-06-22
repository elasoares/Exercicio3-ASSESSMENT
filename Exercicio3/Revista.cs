using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Revista : ItemBiblioteca, IEmprestavel
    {
        private bool _revistaDisponivel;


        public Revista() { }
        public Revista(string titulo, string autor, int anoDePublicacao) : base(titulo, autor, anoDePublicacao)
        {
            _revistaDisponivel = true;
        }

        public override void Devolver()
        {

            _revistaDisponivel = true;
            Console.WriteLine("Revista devolvida.");
        }

        public override void Emprestar()
        {
            if (_revistaDisponivel)
            {
                _revistaDisponivel = false;
                Console.WriteLine("Revista emprestada.");
            }
            else
            {
                Console.WriteLine("Revista não está disponível.");
            }
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Revista {Titulo} por {Autor}, publicado em {AnoDePublicacao}");
        }




        DateTime IEmprestavel.ObterPrazoDeDevolucao()
        {
            return DateTime.Now.AddDays(7);
        }

        bool IEmprestavel.VerificarDisponibilidade()
        {
            return _revistaDisponivel;
        }
    }
}
