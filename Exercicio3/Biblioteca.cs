using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Biblioteca
    {
        private List<ItemBiblioteca> biblioteca;


        public Biblioteca()
        {
            biblioteca = new List<ItemBiblioteca>();
        }


        public void AdicionarItem(ItemBiblioteca item)
        {
            biblioteca.Add(item);
        }
        public void RemoverItem(ItemBiblioteca item)
        {

            if (biblioteca.Remove(item))
            {
                Console.WriteLine($"\nO item {item} foi removido da biblioteca");
            }
            else
            {
                Console.WriteLine("\nO item " + item + " não foi encontrado na biblioteca.");
            }


        }

        public void ExibirItens()
        {
            foreach (var item in biblioteca)
            {
                item.ExibirInformacoes();
            }
        }

        public void RealizarEmprestimo(ItemBiblioteca item)
        {
            item.Emprestar();
        }
    }
}
