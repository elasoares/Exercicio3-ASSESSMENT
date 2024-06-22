using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal abstract class ItemBiblioteca
    {
        private string _titulo;
        private string _autor;
        private int _anoDePublicacao;

        protected ItemBiblioteca() { }
        protected ItemBiblioteca(string titulo, string autor, int anoDePublicacao)
        {
            _titulo = titulo;
            _autor = autor;
            _anoDePublicacao = anoDePublicacao;
        }

        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Autor { get => _autor; set => _autor = value; }
        public int AnoDePublicacao { get => _anoDePublicacao; set => _anoDePublicacao = value; }




        public abstract void Emprestar();
        public abstract void Devolver();
        public abstract void ExibirInformacoes();
    }
}
